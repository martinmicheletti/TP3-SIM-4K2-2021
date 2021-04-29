using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3
{
    public partial class Test : Form
    {
        System.Data.DataTable dt;
        System.Data.DataTable dtTest;
        public Decimal grados_libertad = 0;

        string[] listaChipcuadrada = new string[] {"3,84", "5,99", "7,81", "9,49", "11,14", "12,6", "14,1", "15,5", "16,9", "18,3", "19,7", "21,0", "22,4", "23,7", "25,0", "26.3", "26,3",
                             "27,6", "28,9", "30,1", "31,4", "32,7", "33.9", "35,2", "36,4", "37,7", "38,9", "40,1", "41,3", "42,6", "43,8", "", "", "", "", "", "", "", "", "", "55,8",
                             "", "", "", "", "", "", "", "", "", "67,5", "", "", "", "", "", "", "", "", "", "79,1", "", "", "", "", "", "", "", "", "", "90,5", "", "", "", "", "", "",
                             "", "", "", "101,9", "", "", "", "", "", "", "", "", "", "113,1", "", "", "", "", "", "", "", "", "", "124,3" };

        public Test()
        {
            InitializeComponent();

            cbmIntervalos.SelectedItem = "5";
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
            pnlExponencial.Visible = false;
            pnlNormal.Visible = false;
            pnlPoisson.Visible = false;
            

            if (rbdNormal.Checked)
            {
                pnlNormal.Visible = true;
            }

            if (rbdExponencial.Checked)
            {
                pnlExponencial.Visible = true;
            }

            if (rbdPoisson.Checked)
            {
                pnlPoisson.Visible = true;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                
                validaciones();
                //limpiarGrafico();

                Generadores clase = new Generadores();
                List<Decimal> lista = new List<Decimal>();
                Decimal cant = Convert.ToDecimal(txtCantidad.Text);
               
                if (rbdExponencial.Checked)
                {
                    Decimal media = Convert.ToDecimal(txtMediaExpo.Text);
                    lista = clase.distExponencial(cant, media);
                }
                if (rbdNormal.Checked)
                {
                    Decimal media = Convert.ToDecimal(txtMediaNormal.Text);
                    Decimal desviacion = Convert.ToDecimal(txtDesviacion.Text);
                    lista = clase.distNormal(cant, media, desviacion);
                }
                if (rbdPoisson.Checked)
                {
                    Decimal lambda = Convert.ToDecimal(txtLambda.Text);
                    lista = clase.distPoisson(cant, lambda);

                }


                listValores.Items.Clear();
                foreach (decimal item in lista)
                {
                    listValores.Items.Add(item);
                }

                //TEST!
                Decimal cantInt = Convert.ToDecimal(cbmIntervalos.SelectedItem);


                //valor desde hasta de la serie
               
                Decimal minimo = 0;
                Decimal maximo = 0;
                
                if (rbdNormal.Checked || rbdPoisson.Checked)
                {
                    minimo = lista.Min();
                    maximo = lista.Max();
                }
                if (rbdExponencial.Checked)
                {
                    minimo = 0;
                    maximo = lista.Max();
                }
                //poisson???


                Decimal longitud = maximo - minimo;
                Decimal tamaño_intervalo = Math.Round((longitud / cantInt), 6);

                Decimal desdeInt = minimo;

                Decimal suma = 0;

            

                if (rbdExponencial.Checked)
                {
                    grados_libertad = (cantInt - 1); 

                    Decimal potencia = 0;
                    Decimal resta = 0;
                    Decimal division = 0;
                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Decimal));
                    dt.Columns.Add("Desde", typeof(Decimal));
                    dt.Columns.Add("Hasta", typeof(Decimal));
                    dt.Columns.Add("Marca de Clase", typeof(Decimal));
                    dt.Columns.Add("fo", typeof(Decimal));
                    dt.Columns.Add("fe", typeof(Decimal));
                    dt.Columns.Add("Resta", typeof(Decimal));
                    dt.Columns.Add("Potencia", typeof(Decimal));
                    dt.Columns.Add("Division", typeof(Decimal));

                    Decimal cantidad = Convert.ToDecimal(txtCantidad.Text);

                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Decimal hastaInt = desdeInt + tamaño_intervalo;
                        Decimal fo = 0;
                        Decimal marcaClase = (hastaInt + desdeInt) / 2;

                        Decimal acumMedia = 0;
                        for (int j = 0; j < cantidad; j++)
                        {
                            if (Convert.ToDecimal(lista[j]) < hastaInt && Convert.ToDecimal(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                            }
                            acumMedia = acumMedia + Convert.ToDecimal(lista[j]);

                        }
                        Decimal media = acumMedia / cantidad;
                        Decimal lambda = 1 / media;


                        Decimal probAprox = 0;
                        Decimal fe = 0;
                        for (int j = 0; j < Convert.ToInt32(txtCantidad.Text); j++)
                        {
                            probAprox = Convert.ToDecimal((Convert.ToDouble(lambda) * Math.Exp(Convert.ToDouble((-1 * lambda) * Convert.ToDecimal(marcaClase))))) * tamaño_intervalo;
                            fe = Math.Round((probAprox * cantidad), 4);
                        }

                        resta = fo - fe;
                        potencia = Math.Round(Convert.ToDecimal(Math.Pow(Convert.ToDouble(resta), 2)), 4 );
                        division = Math.Round((potencia / fe), 4);

                        dt.Rows.Add(i, desdeInt, hastaInt, marcaClase, fo, fe,resta,potencia,division);

                        

                        grafico.Series["FO"].Points.AddXY(marcaClase, fo);
                        grafico.Series["FE"].Points.AddXY(marcaClase, fe);


                        desdeInt = desdeInt + tamaño_intervalo;

                    }
                    
               
                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDecimal(dr2["Division"]);
                    }

                   
                }


                if (rbdNormal.Checked)
                {
                    grados_libertad = (cantInt - 2);
                    Decimal potencia = 0;
                    Decimal resta = 0;
                    Decimal division = 0;
                    //calculo media
                    Decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
                    Decimal acumMedia = 0;
                    for (int i = 0; i < lista.Count; i++)
                    {
                        acumMedia = lista[i] + acumMedia;
                    }
                    Decimal mediaNormal = acumMedia / cantidad;

                    //Calculo varianza
                    Decimal sumaVar = 0;
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Decimal resta_var = Math.Abs(lista[i] - mediaNormal);
                        Decimal potencia_var = Convert.ToDecimal(Math.Pow(Convert.ToDouble(resta_var), 2));
                        sumaVar = sumaVar + potencia_var;
                    }
                    Decimal producto = (1 / (cantidad - 1)) * sumaVar;
                    Decimal varianza = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(producto)));

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Decimal));
                    dt.Columns.Add("Desde", typeof(Decimal));
                    dt.Columns.Add("Hasta", typeof(Decimal));
                    dt.Columns.Add("Marca de Clase", typeof(Decimal));
                    dt.Columns.Add("fo", typeof(Decimal));
                    dt.Columns.Add("fe", typeof(Decimal));
                    dt.Columns.Add("Resta", typeof(Decimal));
                    dt.Columns.Add("Potencia", typeof(Decimal));
                    dt.Columns.Add("Division", typeof(Decimal));



                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Decimal hastaInt = desdeInt + tamaño_intervalo;
                        Decimal fo = 0;
                        Decimal fe = 0;


                        Decimal marcaClase = (hastaInt + desdeInt) / 2;

                        for (int j = 0; j < Convert.ToInt32(txtCantidad.Text); j++)
                        {
                            if (Convert.ToDecimal(lista[j]) < hastaInt && Convert.ToDecimal(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                            }
                        }

                        Decimal probAprox = 0;
                       

                        Decimal factor1 = 1 / (varianza * (Convert.ToDecimal(Math.Sqrt(2 * Math.PI))));
                        Decimal exponente = Convert.ToDecimal(Math.Pow(Convert.ToDouble(((marcaClase - mediaNormal) / varianza)), 2));
                        Decimal factor2 = Convert.ToDecimal(Math.Exp(Convert.ToDouble(Convert.ToDecimal(-0.5) * exponente)));

                        probAprox = (factor1 * factor2) * tamaño_intervalo;

                        fe = Math.Round((probAprox * cantidad), 4);

                        resta = fo - fe;
                        potencia = Math.Round(Convert.ToDecimal(Math.Pow(Convert.ToDouble(resta), 2)), 4);
                        division = Math.Round((potencia / fe), 4);

                        dt.Rows.Add(i, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                        grafico.Series["FO"].Points.AddXY(marcaClase, fo);
                        grafico.Series["FE"].Points.AddXY(marcaClase, fe);

                        desdeInt = desdeInt + tamaño_intervalo;

                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDecimal(dr2["Division"]);
                    }

                    
                }



                if (rbdPoisson.Checked)
                {
                    Decimal lamda = Convert.ToDecimal(txtLambda.Text);
                    Double potencia = 0;
                    Double resta = 0;
                    Double division = 0;

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Decimal));
                    dt.Columns.Add("Desde", typeof(Decimal));
                    dt.Columns.Add("Hasta", typeof(Decimal));
                    dt.Columns.Add("Marca de Clase", typeof(Decimal));
                    dt.Columns.Add("fo", typeof(Decimal));
                    dt.Columns.Add("fe", typeof(Decimal));
                    dt.Columns.Add("Resta", typeof(Decimal));
                    dt.Columns.Add("Potencia", typeof(Decimal));
                    dt.Columns.Add("Division", typeof(Decimal));



                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Decimal hastaInt = Convert.ToDecimal(desdeInt + tamaño_intervalo);
                        Double fo = 0;
                        Double fe = 0;
                        Decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
                        Double factor2 = 1;
                        Decimal marcaClase = hastaInt + desdeInt / 2;

                        for (int j = 0; j < Convert.ToInt32(txtCantidad.Text); j++)
                        {
                            if (Convert.ToDecimal(lista[j]) < hastaInt && Convert.ToDecimal(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                                
                               
                            }
                        }

                        Double probAprox = 0;

                        Double factor1 = 0;
                        factor1 = Math.Pow(Math.E,Convert.ToDouble(-lamda)) * Math.Pow(Convert.ToDouble(lamda), Convert.ToDouble(marcaClase));

                        for (int x = 1; x < marcaClase; x++)
                        {
                            factor2 = factor2 * x;

                        }

                        probAprox = factor1 / factor2;
                        

                        fe = Math.Round((probAprox * Convert.ToDouble(cantidad)), 4);

                        resta = fo - fe;
                        potencia = Math.Round(Math.Pow(Convert.ToDouble(resta), 2), 4);
                        division = Math.Round((potencia / fe), 4);

                        dt.Rows.Add(i, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                        grafico.Series["FO"].Points.AddXY(marcaClase, fo);
                        grafico.Series["FE"].Points.AddXY(marcaClase, fe);

                        desdeInt = desdeInt + tamaño_intervalo;

                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDecimal(dr2["Division"]);
                    }



                }



                Double xCalculado = Convert.ToDouble(Math.Round(suma, 6));

              

                Double xTabulado = Convert.ToDouble(listaChipcuadrada[Convert.ToInt32(grados_libertad)]);

                lblRdo.Text = Convert.ToString(xCalculado);

                lblXiTabulado.Text = Convert.ToString(xTabulado);

                if(xTabulado> xCalculado)
                {
                    lblResultado.Text = "NO RECHAZADO";
                    lblResultado.ForeColor = Color.Green;

                }
                else
                {
                    lblResultado.Text =  "RECHAZADO";
                    lblResultado.ForeColor = Color.Red;

                }

                lblGradosLibertad.Text = "Grados de Libertad: " + grados_libertad;

                gvTest.DataSource = dt;

                gvTest.AllowUserToAddRows = false;
                gvTest.AllowUserToDeleteRows = false;

                gvTest.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvTest.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Generadores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void limpiarGrafico()
        {
            //se llama desde el limpiar_click y desde test!
            grafico.Series.Clear();
            grafico.ChartAreas.Clear();
        }
        private void validaciones()
        {
            if (txtCantidad.Text == String.Empty)
            {
                throw new Exception("La cantidad de números es un valor requerido!");
            }
            if (txtCantidad.Text == "0")
            {
                throw new Exception("La cantidad de números no puede ser cero!");
            }

           
            if (rbdNormal.Checked)
            {
                if (txtMediaNormal.Text == String.Empty)
                    throw new Exception("La Media es un valor requerido!");
                if (txtDesviacion.Text == String.Empty)
                    throw new Exception("La Desviación es un valor requerido!");
            }
            if (rbdExponencial.Checked)
            {
                if (txtMediaExpo.Text == String.Empty)
                    throw new Exception("La Media es un valor requerido!");
            }
            if (rbdPoisson.Checked)
            {
                if (txtLambda.Text == String.Empty)
                    throw new Exception("Lambda es un valor requerido!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblGradosLibertad.Text = "Grados de Libertad: ";
            lblXiTabulado.Text = "";
            lblResultado.Text = "";
            //limpiarGrafico();
            grafico.Series[0].Points.Clear();
            grafico.Series[1].Points.Clear();
            txtCantidad.Text = String.Empty;
            txtDesviacion.Text = String.Empty;
            txtMediaExpo.Text = String.Empty;
            txtMediaNormal.Text = String.Empty;
            txtLambda.Text = String.Empty;
            cbmIntervalos.SelectedItem = "5";

            listValores.Items.Clear();

            gvTest.DataSource = null;
           
            
            lblRdo.Text = String.Empty;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbmIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
