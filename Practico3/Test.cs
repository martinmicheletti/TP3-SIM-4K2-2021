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
        public Double grados_libertad = 0;

        string[] listaChipcuadrada = new string[] {"3,84", "5,99", "7,81", "9,49", "11,14", "12,6", "14,1", "15,5", "16,9", "18,3", "19,7", "21,0", "22,4", "23,7", "25,0", "26.3", "26,3",
                             "27,6", "28,9", "30,1", "31,4", "32,7", "33.9", "35,2", "36,4", "37,7", "38,9", "40,1", "41,3", "42,6", "43,8", "44,98", "46,19", "47,39", "48,60", "49,80", "51", "52,19", "53,38", "54,57", "55,8",
                             "", "", "", "", "", "", "", "", "", "67,5", "", "", "", "", "", "", "", "", "", "79,1", "", "", "", "", "", "", "", "", "", "90,5", "", "", "", "", "", "",
                             "", "", "", "101,9", "", "", "", "", "", "", "", "", "", "113,1", "", "", "", "", "", "", "", "", "", "124,3" };

        public Test()
        {
            InitializeComponent();
            txtIntervalos.Text = "";
        }

        private void Test_Load(object sender, EventArgs e)
        {
            pnlUniforme.Visible = false;
            pnlExponencial.Visible = false;
            pnlNormal.Visible = false;
            pnlPoisson.Visible = false;

            if (rbdUniforme.Checked)
            {
                pnlUniforme.Visible = true;
                txtIntervalos.Visible = true;
            }

            if (rbdNormal.Checked)
            {
                pnlNormal.Visible = true;
                txtIntervalos.Visible = true;
            }

            if (rbdExponencial.Checked)
            {
                pnlExponencial.Visible = true;
                txtIntervalos.Visible = true;
            }

            if (rbdPoisson.Checked)
            {
                pnlPoisson.Visible = true;
                txtIntervalos.Visible = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                validaciones();
                //limpiarGrafico();

                Generadores clase = new Generadores();
                List<Double> lista = new List<Double>();
                Double cant = Convert.ToDouble(txtCantidad.Text);

                if (rbdUniforme.Checked)
                {
                    Double a = Convert.ToDouble(txtAUniforme.Text);
                    Double b = Convert.ToDouble(txtBUniforme.Text);
                    lista = clase.distUniforme(cant, a, b);
                }
                if (rbdExponencial.Checked)
                {
                    Double media = Convert.ToDouble(txtMediaExpo.Text);
                    lista = clase.distExponencial(cant, media);
                }
                if (rbdNormal.Checked)
                {
                    Double media = Convert.ToDouble(txtMediaNormal.Text);
                    Double desviacion = Convert.ToDouble(txtDesviacion.Text);
                    lista = clase.distNormal(cant, media, desviacion);
                }
                if (rbdPoisson.Checked)
                {
                    Double lambda = Convert.ToDouble(txtLambda.Text);
                    lista = clase.distPoisson(cant, lambda);
                }

                listValores.Items.Clear();
                foreach (decimal item in lista)
                {
                    listValores.Items.Add(item);
                }

                //TEST!
                //Double cantInt = Convert.ToDouble(txtIntervalos.Text);

                //valor desde hasta de la serie

                Double minimo = 0;
                Double maximo = 0;
                Double cantInt = 0;
                
                if (rbdUniforme.Checked || rbdNormal.Checked)
                {
                    minimo = Convert.ToDouble(lista.Min());
                    maximo = Convert.ToDouble(lista.Max());
                    cantInt = Convert.ToDouble(txtIntervalos.Text);
                }
                if (rbdExponencial.Checked)
                {
                    minimo = 0;
                    maximo = Convert.ToDouble(lista.Max());
                    cantInt = Convert.ToDouble(txtIntervalos.Text);
                }
                if (rbdPoisson.Checked)
                {
                    minimo = Convert.ToDouble(lista.Min());
                    maximo = Convert.ToDouble(lista.Max());
                    cantInt = maximo - minimo;
                }

                Double cantidadIntervalosReales = 0;

                Double longitud = maximo - minimo;
                Double tamaño_intervalo = Math.Round((longitud / cantInt), 6);
                Double desdeInt = minimo;

                Double suma = 0;

                if (rbdUniforme.Checked)
                {
                   
                    Double potencia = 0;
                    Double resta = 0;
                    Double division = 0;

                    var a = Convert.ToDouble(txtAUniforme.Text);
                    var b = Convert.ToDouble(txtBUniforme.Text);

                    //calculo media
                    Double mediaUniforme = (a + b) / 2;

                    Double cantidad = Convert.ToDouble(txtCantidad.Text);

                    //Calculo varianza

                    Double varianzaUniforme = Math.Pow((b - a), 2) / 12;

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Double));
                    dt.Columns.Add("Desde", typeof(Double));
                    dt.Columns.Add("Hasta", typeof(Double));
                    dt.Columns.Add("Marca de Clase", typeof(Double));
                    dt.Columns.Add("fo", typeof(Double));
                    dt.Columns.Add("fe", typeof(Double));
                    dt.Columns.Add("Resta", typeof(Double));
                    dt.Columns.Add("Potencia", typeof(Double));
                    dt.Columns.Add("Division", typeof(Double));

                    Double tamañoIntervaloAcumulado = 0;
                    Double filasAcumuladas = 0;     

                    // lleno el vector de fo 
                    // For principal, recorre cada fila por cada intervalo
                    for (int i = 1; i <= cantInt; i++)
                    {
                        
                        Double hastaInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;
                        Double fo = 0;
                        Double fe = 0;

                        Double marcaClase = (hastaInt + desdeInt) / 2;

                        for (int j = 0; j < cantidad; j++)
                        {
                            // Si el valor se encuentra entre los limites
                            // no incluye el limite superior
                            if (Convert.ToDouble(lista[j]) < hastaInt && Convert.ToDouble(lista[j]) >= desdeInt)
                            {
                                fo += 1;
                            }
                        }

                        // Si la frecuencia observada es menor a 5,
                        // se suma con otro intervalo
                        if (fo < 5)
                        {
                            filasAcumuladas += 1;
                            tamañoIntervaloAcumulado += tamaño_intervalo;
                        } else
                        {
                            Double funcionDensidad = 1 / (b - a);

                            fe = (Math.Round((funcionDensidad * Convert.ToDouble(tamaño_intervalo + tamañoIntervaloAcumulado)), 4)) * cantidad;
                            resta = fo - fe;
                            potencia = Math.Round(Convert.ToDouble(Math.Pow(Convert.ToDouble(resta), 2)), 4);
                            division = Math.Round((potencia / fe), 4);

                            dt.Rows.Add(cantidadIntervalosReales+1, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                            grafico.Series["FO"].Points.AddXY(Math.Round(marcaClase, 2), fo);
                            grafico.Series["FE"].Points.AddXY(Math.Round(marcaClase, 2), fe);

                            desdeInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;

                            filasAcumuladas = 0;
                            tamañoIntervaloAcumulado = 0;
                            cantidadIntervalosReales += 1;
                        }
                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDouble(dr2["Division"]);
                    }

                    grados_libertad = (Convert.ToDouble(cantidadIntervalosReales) - 1);
                }

                if (rbdExponencial.Checked)
                {
                    
                    Double potencia = 0;
                    Double resta = 0;
                    Double division = 0;

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Double));
                    dt.Columns.Add("Desde", typeof(Double));
                    dt.Columns.Add("Hasta", typeof(Double));
                    dt.Columns.Add("Marca de Clase", typeof(Double));
                    dt.Columns.Add("fo", typeof(Double));
                    dt.Columns.Add("fe", typeof(Double));
                    dt.Columns.Add("Resta", typeof(Double));
                    dt.Columns.Add("Potencia", typeof(Double));
                    dt.Columns.Add("Division", typeof(Double));

                    Double cantidad = Convert.ToDouble(txtCantidad.Text);

                    Double tamañoIntervaloAcumulado = 0;
                    Double filasAcumuladas = 0;

                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Double hastaInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;
                        Double fo = 0;
                        Double marcaClase = (hastaInt + desdeInt) / 2;

                        Double acumMedia = 0;

                        for (int j = 0; j < cantidad; j++)
                        {
                            if (Convert.ToDouble(lista[j]) < hastaInt && Convert.ToDouble(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                            }
                            acumMedia = acumMedia + Convert.ToDouble(lista[j]);
                        }

                        if (fo < 5)
                        {
                            filasAcumuladas += 1;
                            tamañoIntervaloAcumulado += tamaño_intervalo;
                        }
                        else
                        {

                            Double media = acumMedia / cantidad;
                            Double lambda = 1 / media;
                            Double probAprox = 0;
                            Double fe = 0;

                            for (int j = 0; j < Convert.ToInt32(txtCantidad.Text); j++)
                            {
                                probAprox = Convert.ToDouble((lambda * Math.Exp((-1 * lambda) * marcaClase))) * (tamaño_intervalo + tamañoIntervaloAcumulado);
                                fe = Math.Round((probAprox * cantidad), 4);
                            }

                            resta = fo - fe;
                            Double cuadrado = 2;
                            potencia = Math.Round(Math.Pow(resta, cuadrado), 4);
                            division = Math.Round((potencia / fe), 4);

                            dt.Rows.Add(cantidadIntervalosReales+1, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                            grafico.Series["FO"].Points.AddXY(Math.Round(marcaClase, 2), fo);
                            grafico.Series["FE"].Points.AddXY(Math.Round(marcaClase, 2), fe);

                            desdeInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;

                            filasAcumuladas = 0;
                            tamañoIntervaloAcumulado = 0;
                            cantidadIntervalosReales += 1;
                        }
                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDouble(dr2["Division"]);
                    }

                    // GDL = Intervalos - 1 - 1 dato empirico (lambda)
                    grados_libertad = (Convert.ToDouble(cantidadIntervalosReales) - 1 - 1);
                }

                if (rbdNormal.Checked)
                {
                    
                    Double potencia = 0;
                    Double resta = 0;
                    Double division = 0;

                    //calculo media
                    Double cantidad = Convert.ToDouble(txtCantidad.Text);
                    Double acumMedia = 0;

                    for (int i = 0; i < lista.Count; i++)
                    {
                        acumMedia = Convert.ToDouble(lista[i]) + acumMedia;
                    }

                    Double mediaNormal = acumMedia / cantidad;

                    //Calculo varianza
                    Double sumaVar = 0;

                    for (int i = 0; i < lista.Count; i++)
                    {
                        Double resta_var = Math.Abs(Convert.ToDouble(lista[i]) - mediaNormal);
                        Double potencia_var = Convert.ToDouble(Math.Pow(Convert.ToDouble(resta_var), 2));
                        sumaVar = sumaVar + potencia_var;
                    }

                    Double producto = (1 / (cantidad - 1)) * sumaVar;
                    Double varianza = Convert.ToDouble(Math.Sqrt(Convert.ToDouble(producto)));

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Double));
                    dt.Columns.Add("Desde", typeof(Double));
                    dt.Columns.Add("Hasta", typeof(Double));
                    dt.Columns.Add("Marca de Clase", typeof(Double));
                    dt.Columns.Add("fo", typeof(Double));
                    dt.Columns.Add("fe", typeof(Double));
                    dt.Columns.Add("Resta", typeof(Double));
                    dt.Columns.Add("Potencia", typeof(Double));
                    dt.Columns.Add("Division", typeof(Double));

                    Double tamañoIntervaloAcumulado = 0;
                    Double filasAcumuladas = 0;

                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Double hastaInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;
                        Double fo = 0;
                        Double fe = 0;
                        Double marcaClase = (hastaInt + desdeInt) / 2;

                        for (int j = 0; j < Convert.ToInt32(txtCantidad.Text); j++)
                        {
                            if (Convert.ToDouble(lista[j]) < hastaInt && Convert.ToDouble(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                            }
                        }

                        if (fo < 5)
                        {
                            filasAcumuladas += 1;
                            tamañoIntervaloAcumulado += tamaño_intervalo;
                        }
                        else
                        {
                            Double probAprox = 0;
                            Double factor1 = 1 / (varianza * (Convert.ToDouble(Math.Sqrt(2 * Math.PI))));
                            Double exponente = Convert.ToDouble(Math.Pow(Convert.ToDouble(((marcaClase - mediaNormal) / varianza)), 2));
                            Double factor2 = Convert.ToDouble(Math.Exp(Convert.ToDouble(Convert.ToDouble(-0.5) * exponente)));

                            probAprox = (factor1 * factor2) * (tamaño_intervalo + tamañoIntervaloAcumulado);

                            fe = Math.Round((probAprox * cantidad), 4);

                            resta = fo - fe;
                            potencia = Math.Round(Convert.ToDouble(Math.Pow(Convert.ToDouble(resta), 2)), 4);
                            division = Math.Round((potencia / fe), 4);

                            dt.Rows.Add(cantidadIntervalosReales + 1, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                            grafico.Series["FO"].Points.AddXY(Math.Round(marcaClase, 2), fo);
                            grafico.Series["FE"].Points.AddXY(Math.Round(marcaClase, 2), fe);

                            desdeInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;

                            filasAcumuladas = 0;
                            tamañoIntervaloAcumulado = 0;
                            cantidadIntervalosReales += 1;
                        }
                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDouble(dr2["Division"]);
                    }

                    grados_libertad = (Convert.ToDouble(cantidadIntervalosReales) - 1 - 2);
                }

                if (rbdPoisson.Checked)
                {
                    
                    //tamaño_intervalo = Math.Ceiling((maximo - minimo) / cantInt);

                    tamaño_intervalo = 1;

                    Double lamda = Convert.ToDouble(txtLambda.Text);
                    Double potencia = 0;
                    Double resta = 0;
                    Double division = 0;

                    dt = new System.Data.DataTable();
                    dt.Columns.Add("Nro Intervalo", typeof(Double));
                    dt.Columns.Add("Desde", typeof(Double));
                    dt.Columns.Add("Hasta", typeof(Double));
                    dt.Columns.Add("Marca de Clase", typeof(Double));
                    dt.Columns.Add("fo", typeof(Double));
                    dt.Columns.Add("fe", typeof(Double));
                    dt.Columns.Add("Resta", typeof(Double));
                    dt.Columns.Add("Potencia", typeof(Double));
                    dt.Columns.Add("Division", typeof(Double));

                    Double tamañoIntervaloAcumulado = 0;
                    Double filasAcumuladas = 0;

                    Double frecuenciaEsperadaTotal = 0;
                    //lleno el vector de fo 
                    for (int i = 1; i <= cantInt; i++)
                    {
                        Double hastaInt = Convert.ToDouble(desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado);
                        Double fo = 0;
                        Double fe = 0;
                        Double cantidad = Convert.ToDouble(txtCantidad.Text);
                        Double factor2 = 1;
                        Double marcaClase = Math.Floor((hastaInt + desdeInt) / 2);

                        for (int j = 0; j < cantidad; j++)
                        {
                            if (Convert.ToDouble(lista[j]) < hastaInt && Convert.ToDouble(lista[j]) >= desdeInt) //no incluye el limite superior
                            {
                                fo = fo + 1;
                            }
                        }

                        if (fo < 5)
                        {
                            filasAcumuladas += 1;
                            tamañoIntervaloAcumulado += tamaño_intervalo;
                        }
                        else
                        {
                            Double probAprox = 0;

                            Double factor1 = 0;
                            factor1 = Math.Pow(Math.E, Convert.ToDouble(-lamda)) * Math.Pow(Convert.ToDouble(lamda), Convert.ToDouble(marcaClase));

                            for (int x = 1; x <= marcaClase; x++)
                            {
                                factor2 = factor2 * x;
                            }

                            probAprox = factor1 / factor2;

                            fe = Math.Round((probAprox * Convert.ToDouble(cantidad)), 4);

                            frecuenciaEsperadaTotal += fe;

                            resta = fo - fe;
                            potencia = Math.Round(Math.Pow(Convert.ToDouble(resta), 2), 4);

                            if (fe == 0)
                            {
                                division = 0;
                            }
                            else
                            {
                                division = Math.Round((potencia / fe), 4);
                            }

                            dt.Rows.Add(cantidadIntervalosReales+1, desdeInt, hastaInt, marcaClase, fo, fe, resta, potencia, division);

                            grafico.Series["FO"].Points.AddXY(Math.Round(marcaClase, 2), fo);
                            grafico.Series["FE"].Points.AddXY(Math.Round(marcaClase, 2), fe);

                            desdeInt = desdeInt + tamaño_intervalo + tamañoIntervaloAcumulado;

                            filasAcumuladas = 0;
                            tamañoIntervaloAcumulado = 0;
                            cantidadIntervalosReales += 1;
                        }
                    }

                    foreach (DataRow dr2 in dt.Rows)
                    {
                        suma = suma + Convert.ToDouble(dr2["Division"]);
                    }

                    dt.Rows.Add(0,0,0,0,0,frecuenciaEsperadaTotal,0,0,0);

                    grados_libertad = (Convert.ToDouble(cantidadIntervalosReales) - 2);
                }

                Double xCalculado = Convert.ToDouble(Math.Round(suma, 6));

                Double xTabulado = Convert.ToDouble(listaChipcuadrada[Convert.ToInt32(grados_libertad)]);

                lblRdo.Text = xCalculado.ToString();

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
            if (rbdUniforme.Checked)
            {
                if (txtAUniforme.Text == String.Empty)
                    throw new Exception("Ingrese un valor para el parámetro 'a'");
                if (txtBUniforme.Text == String.Empty)
                    throw new Exception("Ingrese un valor para el parámetro 'b'");
                if (Convert.ToDouble(txtAUniforme.Text) >= Convert.ToDouble(txtBUniforme.Text))
                    throw new Exception("El valor 'B' ingresado debe ser mayor a el valor 'A'");
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
            txtIntervalos.Text = "";
            txtAUniforme.Text = "";
            txtBUniforme.Text = "";
            txtIntervalos.Visible = true;
            listValores.Items.Clear();

            rbdUniforme.Checked = false;
            rbdNormal.Checked = false;
            rbdPoisson.Checked = false;
            rbdExponencial.Checked = false;

            gvTest.DataSource = null;

            lblRdo.Text = String.Empty;
        }

        private void rbdUniforme_CheckedChanged(object sender, EventArgs e)
        {
            pnlUniforme.Visible = true;
        }
    }
}
