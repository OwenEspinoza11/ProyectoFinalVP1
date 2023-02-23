namespace ProyectoFinalVP1
{
    public partial class frmEstadoResultado : Form
    {
        public frmEstadoResultado()
        {
            InitializeComponent();
        }

        private void frmEstadoResultado_Load(object sender, EventArgs e)
        {

            //casillas que necesitan ser calculadas
            txtUtilidadBruta.Enabled = false;
            txtUtilidadAntesImpuesto.Enabled = false;
            txtUtilidadDeOperacion.Enabled = false;
            txtUtilidadNeta.Enabled = false;
            txtIR.Enabled = false;

            //se necesita calcular la utilidad bruta para desbloquear
            mtxtGastosDeOperacion.Enabled = false;

            //se necesita calcular la utilidad de operacion para desbloquear
            mtxtGastosVenta.Enabled = false;


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double VT, CV, UTB, GOP, UTOP, GV, UTAI, IR, UTNe;
            string NomEmpresa;

            if (txtNombreEmpresa.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la empresa");
            }
            else if (dtpF1.Text == dtpF2.Text)
            {
                MessageBox.Show("El rango de fecha debe ser de por " +
                    "lo menos 1 mes de diferencia");
            }
            else if (treeView1.SelectedNode.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una rama");
            }
            else
            {
                VT = Convert.ToDouble(mtxtVentasTotales);
                CV = Convert.ToDouble(mtxtCostoDeVentas);
                GOP = Convert.ToDouble(mtxtGastosDeOperacion);
                GV = Convert.ToDouble(mtxtGastosVenta);


                if (treeView1.SelectedNode.Text.Equals("Utilidad bruta"))
                {
                    if (mtxtVentasTotales.Text == "")
                    {
                        MessageBox.Show("Ingrese un valor válido");
                        mtxtVentasTotales.Focus();
                    }
                    else if (mtxtCostoDeVentas.Text == "")
                    {
                        MessageBox.Show("Ingrese un valor válido");
                        mtxtCostoDeVentas.Focus();
                    }

                    if (VT > 10000 || VT < 10000000 || CV > 5000 || CV < 5000000)
                    {
                        //primer paso
                        UTB = VT - CV;

                        txtUtilidadBruta.Text = UTB.ToString();
                        mtxtGastosDeOperacion.Enabled = true;

                        if (treeView1.SelectedNode.Text.Equals("Utilidad de operacion"))
                        {
                            if (mtxtGastosDeOperacion.Text == "")
                            {
                                MessageBox.Show("Ingrese un valor válido");
                                mtxtGastosDeOperacion.Focus();
                            }

                            if (GOP < UTB)
                            {
                                //segundo paso
                                UTOP = UTB - GOP;

                                txtUtilidadDeOperacion.Text = UTOP.ToString();
                                mtxtGastosVenta.Enabled = true;

                                if (treeView1.SelectedNode.Text.Equals("Utilidad a/impuesto"))
                                {
                                    if (mtxtGastosVenta.Text == "")
                                    {
                                        MessageBox.Show("Ingrese un valor válido");
                                        mtxtGastosVenta.Focus();
                                    }

                                    if (GV < UTOP)
                                    {

                                        //tercer paso
                                        UTAI = UTOP - GV;

                                        txtUtilidadAntesImpuesto.Text = UTAI.ToString();

                                        if (treeView1.SelectedNode.Text.Equals("Utilidad neta"))
                                        {
                                            //cuarto paso
                                            IR = UTAI * 0.15;
                                            txtIR.Text = IR.ToString();


                                            UTNe = UTAI - IR;
                                            txtUtilidadNeta.Text = UTNe.ToString();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Los gastos de venta " +
                                            "no pueden ser mayores a la utilidad " +
                                            "de operacion");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Los gastos operativos no " +
                                    "pueden ser mayor a la utilidad bruta");
                            }
                        }
                        else if (VT < CV)
                        {
                            MessageBox.Show("Las ventas totales deben ser mayores a los costos");
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor dentro del rango");
                        }
                    }
                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtGastosDeOperacion.Clear();
            mtxtVentasTotales.Clear();
            mtxtCostoDeVentas.Clear();
            mtxtGastosVenta.Clear();


            txtUtilidadAntesImpuesto.Clear();
            txtUtilidadDeOperacion.Clear();
            txtUtilidadBruta.Clear();
            txtUtilidadNeta.Clear();
            txtIR.Clear();

            mtxtVentasTotales.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}