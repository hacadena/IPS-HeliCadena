using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCalcularLiquidacion_Click(object sender, EventArgs e)
        {
            string numeroLiquidacion;
            string idPaciente;
            string tipoAfiliacion;
            double salarioPaciente;
            double valorServicio;

            Console.WriteLine("Digite numero de liquidacion:");
            numeroLiquidacion = cajaNumeroDeLiquidacion.Text;
            Console.WriteLine("DIgite su identificacion:");
            idPaciente = cajaIdentificacion.Text;
            Console.WriteLine("Digite tipo de afiliación: S=> para regimen Subsidiado y C=>Contribitivo");
            tipoAfiliacion = comboTipoDeAfiliacion.Text; 
            Console.WriteLine("Digite su salario devengado:");
            salarioPaciente = double.Parse(cajaSalario.Text);
            Console.WriteLine("Digite el valor del servicio prestado");
            valorServicio = double.Parse(cajaValorDelServicio.Text);
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;

            if (tipoAfiliacion == "Contributivo")
            {
                liquidacionCuotaModeradora = new LiquidacionContributivo(numeroLiquidacion, idPaciente, tipoAfiliacion, salarioPaciente, valorServicio);
            }
            else
            {
                liquidacionCuotaModeradora = new LiquidacionSubsidiado(numeroLiquidacion, idPaciente, tipoAfiliacion, salarioPaciente, valorServicio);
            }

            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();

            liquidacionCuotaModeradora.CalcularCuotaModeradora();
            Console.WriteLine(liquidacionCuotaModeradoraService.Guardar(liquidacionCuotaModeradora));
            var response = liquidacionCuotaModeradoraService.Consultar();
            if (response.Error)
            {
                Console.WriteLine(response.Message);
            }
            else
            {
                foreach (var item in response.Liquidaciones)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            //MessageBox.Show($"Su liquidacion es:{liquidacionCuotaModeradora.CuotaModeradora}");
            cajaValorDeLiquidacion.Text=($"{liquidacionCuotaModeradora.CuotaModeradora}");
           

        }
    }
}
