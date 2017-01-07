using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conv_Unid
{
    public partial class Frm_Fondo : Form
    {
        private string Formato = "0.##";
        int val = 0;//valor que me dira cuando los valores esten correctos
        public Frm_Fondo()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }


        private void Frm_Fondo_Load(object sender, EventArgs e)
        { }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //acerca de 
            MessageBox.Show("ACCADYA - Oil & Training Group  \n\n Somos una empresa dedicada a la asesoría de Proyectos de Ingeniería en múltiples áreas de servicio, Formación de Personal y Apoyo Académico Integral.\n\n ¡Fórmate con nosotros! Visitanos y entérate de nuestros cursos.\n\n Para mayor información : http://www.accadya.com.ve/ \n\n Siguenos en nuestras redes sociales : \n Facebook : accadyaasesores.com.ve \n Instagram : @accadya_asesores \n Twitter : @accadyaasesores", "Acerca de ACCADYA");
        }

        //Borra los textBox
        private void btnBorrar_Click(object sender, EventArgs e)
            => tb1.Text = tb2.Text = tb3.Text = tb4.Text = tb5.Text = tb6.Text = tb7.Text = tb8.Text = tb9.Text = "";

        private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnidades.SelectedIndex == 0)
            {//Longitud
                cambiarLabels("m", "pie", "km", "milla", "yarda", "pulg", "cm", "mm", "micra");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();
            }
            else if (cbUnidades.SelectedIndex == 1)
            {//area
                cambiarLabels("m2", "pie2", "km2", "milla2", "acre", "hectárea", "pulg2", "cm2", "yarda2");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 2)
            { //volumen
                cambiarLabels("m3", "gal(US)", "L", "barril(US)", "pie3", "cm3", "pulg3", "yarda3", "acre pie");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 3)
            {//temperatura
                cambiarLabels("ºC", "ºF", "ºK", "ºR(Rankine)", "", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 4)
            {//presion
                cambiarLabels("bar", "psi", "kPa", "atm", "kg/cm2", "mm Hg(torr)", "pie agua", "cm agua", "Pa(N/m2)");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 5)
            {//masa 
                cambiarLabels("kg", "lb", "g", "mg", "onza", "slug", "TM(tonne)", "Ton(US)", "Ton(UK)");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 6)
            {//moles
                cambiarLabels("mol", "kmol", "lbmol", "N m3", "scf", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 7)
            {//densidad
                cambiarLabels("kg/m3", "lb/pie3", "kg/L", "g/cm3", "lb/gal", "lb/pulg3", "API", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 8)
            {//energia
                cambiarLabels("kJ", "kcal", "Btu", "kW h", "HP s", "lbf pie", "kgf m", "J", "cal");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 9)
            {//potencia
                cambiarLabels("kW", "HP", "kcal/h", "Btu/h", "kgf m/s", "lbf pie/s", "W(J/s)", "Btu/s", "cal/s");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 10)
            {//flujo volumetrico
                cambiarLabels("m3/s", "CFM", "pie3/s", "GPM", "b/d(bpsd)", "m3/h", "L/min", "L/s", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = true;
                tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 11)
            {//flujo masico
                cambiarLabels("kg/s", "kg/h", "g/s", "TM/h", "TM/d", "lb/s", "lb/h", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 12)
            {//flujo molar
                cambiarLabels("mol/s", "kmol/s", "kmol/h", "lbmol/s", "lbmol/h", "N m3/h", "N L/h", "scf/h", "SCFM");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 13)
            {//velocidad
                cambiarLabels("m/s", "km/h", "MPH", "nudo", "pie/s", "cm/s", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 14)
            { //visco cinematica
                cambiarLabels("m2/s", "pie2/s", "st(cm2/s)", "cSt", "cm2/h", "pie2/h", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 15)
            {//visco dinamica
                cambiarLabels("kg/m s", "lb/pie s", "P(g/cm s)", "cP", "Pa s", "lb/pie h", "g/cm s", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 16)
            {//cond termica
                cambiarLabels("kW/m K", "cal/s cm ºC", "Btu/h pie ºF", "W/m K", "", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 17)
            {//coef transf de calor
                cambiarLabels("W/m2 K", "Kcal/h m2 ºC", "Btu/h pie2 ºF", "cal/s cm2 ºC", "kW/m2 ºC", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 18)
            {//entalpia especifica
                cambiarLabels("kJ/kg", "J/g", "J/kg", "cal/g", "Btu/lb", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 19)
            {//entropia especif
                cambiarLabels("kJ/kg K", "J/kg K", "cal/g ºC", "Btu/lb ºF", "", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 20)
            {//vol especif
                cambiarLabels("m3/kg", "cm3/g", "pie3/lb", "pulg3/lb", "gal(US)/lb", "L/kg", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 21)
            {//angulo plano
                cambiarLabels("º(grados)", "radianes", "'(minutos)", "''(segundos)", "revoluciones", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 22)
            {//tiempo
                cambiarLabels("seg", "min", "horas", "día", "año(365días)", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
            else if (cbUnidades.SelectedIndex == 23)
            {//fuerza
                cambiarLabels("N", "dina", "lbf", "kgf", "", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
                realizarCalculos();

            }
        }
        private void calcularValores(float vTb1, TextBox tb2, float valor1, TextBox tb3, float valor2, TextBox tb4, float valor3, TextBox tb5, float valor4, TextBox tb6, float valor5, TextBox tb7, float valor6, TextBox tb8, float valor7, TextBox tb9, float valor8)
        {
            tb2.Text = "" + (vTb1 * valor1).ToString(Formato);
            tb3.Text = "" + (vTb1 * valor2).ToString(Formato);
            tb4.Text = "" + (vTb1 * valor3).ToString(Formato);
            tb5.Text = "" + (vTb1 * valor4).ToString(Formato);
            tb6.Text = "" + (vTb1 * valor5).ToString(Formato);
            tb7.Text = "" + (vTb1 * valor6).ToString(Formato);
            tb8.Text = "" + (vTb1 * valor7).ToString(Formato);
            tb9.Text = "" + (vTb1 * valor8).ToString(Formato);
        }

        private void cambiarLabels(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9)
        {
            lb1.Text = v1;
            lb2.Text = v2;
            lb3.Text = v3;
            lb4.Text = v4;
            lb5.Text = v5;
            lb6.Text = v6;
            lb7.Text = v7;
            lb8.Text = v8;
            lb9.Text = v9;
        }

        // validar datos
        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb1.Text != "")
            {
                validarDatos(e);
                realizarCalculos();
            }
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb2.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb3.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb3
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb4.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb4
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb5.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb5
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb6.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb6
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb7.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb17
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb8.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb8
            else
            {
                lMsjError.Visible = false;
            }
        }
        private void tb9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb9.Text != "")
            {
                validarDatos(e);
                realizarCalculos();

            }//tb9
            else
            {
                lMsjError.Visible = false;
            }
        }
        public void realizarCalculos()
        {
            if (cbUnidades.SelectedIndex == 0)
            { //longitud 
              //si el valor esta en metros
                if (tb1.Text != "")
                {
                    float vTb1 = float.Parse(tb1.Text);// guardo el valor en vtb1
                    calcularValores(vTb1, tb2, 3.2F, tb3, 1000.0F, tb4, 0.0F, tb5, 1.0F, tb6, 39.3F, tb7, 100.0F, tb8, 1000.0F, tb9, 1000000.0F);
                }
                //si el valor esta en pies
                else if (tb2.Text != "")
                { //metrosPie = calculo metros dado el valor de pie
                    float vTb2 = float.Parse(tb2.Text);
                    calcularValores(vTb2, tb1, 0.3F, tb3, 0.0F, tb4, 0.0F, tb5, 0.3F, tb6, 12.0F, tb7, 30.4F, tb8, 304.8F, tb9, 304800.0F);
                }
                //si el valor esta en km
                else if (tb3.Text != "")
                {  //metrosKm = calculo metros dado km
                    float vTb3 = float.Parse(tb3.Text);
                    calcularValores(vTb3, tb1, 1000.0F, tb2, 3280.8F, tb4, 0.6F, tb5, 1093.6F, tb6, 39370.0F, tb7, 100000.0F, tb8, 1000000.0F, tb9, 1000000000.0F);
                }
                //si el valor esta en milla
                else if (tb4.Text != "")
                { // m_milla = milla dado los metros
                    float vTb4 = float.Parse(tb4.Text);
                    calcularValores(vTb4, tb1, 1609.3F, tb2, 5280.0F, tb3, 1.6F, tb5, 1760.0F, tb6, 63360.0F, tb7, 160934.0F, tb8, 1609344.0F, tb9, 1609344000.6F);
                }
                //si el valor esta en yardas
                else if (tb5.Text != "")
                { //m_yarda = yarda dado los metros
                    float vTb5 = float.Parse(tb5.Text);
                    calcularValores(vTb5, tb1, 0.9F, tb2, 3.0F, tb3, 0.0F, tb4, 914.4F, tb6, 36.0F, tb7, 91.4F, tb8, 914.4F, tb9, 914400.0F);
                }
                //si el valor esta en pulg
                else if (tb6.Text != "")
                {//m_pulg = m dado los pulg
                    float vTb6 = float.Parse(tb6.Text);
                    calcularValores(vTb6, tb1, 0.02F, tb2, 0.08F, tb3, 0.0F, tb4, 0.0F, tb5, 0.02F, tb7, 2.5F, tb8, 25.4F, tb9, 25400.0F);
                }
                //si el valor esta en cm
                else if (tb7.Text != "")
                {//m_cm = m dado los cm
                    float vTb7 = float.Parse(tb7.Text);
                    calcularValores(vTb7, tb1, 0.01F, tb2, 0.03F, tb3, 0.0F, tb4, 0.0F, tb5, 0.01F, tb6, 0.3F, tb8, 10.0F, tb9, 10000.0F);
                }
                //si el valor esta en mm
                else if (tb8.Text != "")
                {//m_mm = m dado los mm
                    float vTb8 = float.Parse(tb8.Text);
                    calcularValores(vTb8, tb1, 0.001F, tb2, 0.003F, tb3, 0.0F, tb4, 0.0F, tb5, 0.001F, tb6, 0.03F, tb7, 0.1F, tb9, 1000.0F);
                }
                //si el valor esta en micra
                else if (tb9.Text != "")
                { //m_micra = micra dado los metros
                    float vTb9 = float.Parse(tb9.Text);
                    calcularValores(vTb9, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F);
                }

                //LLenar el comboBox con una lista
                //List<string> combo = new List<string>();
                //combo.Add("Longitud");
                //cbUnidades.DataSource = combo;

            }//comboBox item o
            else if (cbUnidades.SelectedIndex == 1)
            {
                //area
                if (tb1.Text != "")
                { // valor en m2
                    float area_vTb1 = float.Parse(tb1.Text);
                    calcularValores(area_vTb1, tb2, 10.7F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 1550.0F, tb8, 10000.0F, tb9, 1.19F);
                }
                else if (tb2.Text != "")
                {
                    //valor en pi2
                    float area_vTb2 = float.Parse(tb2.Text);
                    calcularValores(area_vTb2, tb1, 0.09F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 143.99F, tb8, 929.03F, tb9, 0.11F);
                }
                else if (tb3.Text != "")
                {
                    //valor en km2
                    float area_vTb3 = float.Parse(tb3.Text);
                    calcularValores(area_vTb3, tb1, 1000000.0F, tb2, 10763910.42F, tb4, 0.39F, tb5, 247.11F, tb6, 100.0F, tb7, 1550003100.0F, tb8, 10000000000.0F, tb9, 1195990.05F);
                }
                else if (tb4.Text != "")
                {
                    //valor en milla2
                    float area_vTb4 = float.Parse(tb4.Text);
                    calcularValores(area_vTb4, tb1, 2589988.11F, tb2, 27878399.97F, tb3, 2.59F, tb5, 640.0F, tb6, 258.99F, tb7, 4014489595.23F, tb8, 25899881072.67F, tb9, 3097599.99F);
                }
                else if (tb5.Text != "")
                {
                    //valor en acre
                    float area_vTb5 = float.Parse(tb5.Text);
                    calcularValores(area_vTb5, tb1, 4046.8564F, tb2, 43560.0F, tb3, 0.0F, tb4, 0.0F, tb6, 0.4F, tb7, 6272640.01F, tb8, 40468564.30F, tb9, 4840.0F);
                }
                else if (tb6.Text != "")
                {
                    //valor en hecta
                    float area_vTb6 = float.Parse(tb6.Text);
                    calcularValores(area_vTb6, tb1, 10000.0F, tb2, 107639.10F, tb3, 0.01F, tb4, 0.0F, tb5, 2.47F, tb7, 15500031.0F, tb8, 100000000.0F, tb9, 11959.9F);
                }
                else if (tb7.Text != "")
                {
                    //valor en pulg2
                    float area_vTb7 = float.Parse(tb7.Text);
                    calcularValores(area_vTb7, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb8, 6.45F, tb9, 0.0F);
                }
                else if (tb8.Text != "")
                {
                    //valor en cm2
                    float area_vTb8 = float.Parse(tb8.Text);
                    calcularValores(area_vTb8, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.16F, tb9, 0.0F);
                }
                else if (tb9.Text != "")
                {
                    //valor en yarda2
                    float area_vTb9 = float.Parse(tb9.Text);
                    calcularValores(area_vTb9, tb1, 0.84F, tb2, 9.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 1296.0F, tb8, 8361.27F);
                }
            }//comboBox item 1
            else if (cbUnidades.SelectedIndex == 2)
            {
                //volumen
                if (tb1.Text != "")
                {
                    //valor en m3
                    float volumen_vTb1 = float.Parse(tb1.Text);
                    calcularValores(volumen_vTb1, tb2, 264.17F, tb3, 1000.0F, tb4, 6.29F, tb5, 35.32F, tb6, 1000000.0F, tb7, 61023.75F, tb8, 1.3F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {
                    //valor en gal
                    float volumen_vTb2 = float.Parse(tb2.Text);
                    calcularValores(volumen_vTb2, tb1, 0.003F, tb3, 3.79F, tb4, 0.024F, tb5, 0.13F, tb6, 3785.4F, tb7, 231.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {
                    //valor en L
                    float volumen_vTb3 = float.Parse(tb3.Text);
                    calcularValores(volumen_vTb3, tb1, 0.0F, tb2, 0.26F, tb4, 0.0F, tb5, 0.035F, tb6, 1000.0F, tb7, 61.02F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {
                    //valor en barril
                    float volumen_vTb4 = float.Parse(tb4.Text);
                    calcularValores(volumen_vTb4, tb1, 0.16F, tb2, 42.0F, tb3, 158.99F, tb5, 5.61F, tb6, 158987.29F, tb7, 9702.0F, tb8, 0.21F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {
                    //valor en pie3
                    float volumen_vTb5 = float.Parse(tb5.Text);
                    calcularValores(volumen_vTb5, tb1, 0.03F, tb2, 7.48F, tb3, 28.32F, tb4, 0.17F, tb6, 28316.85F, tb7, 1728.0F, tb8, 0.04F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {
                    //valor en cm3
                    float volumen_vTb6 = float.Parse(tb6.Text);
                    calcularValores(volumen_vTb6, tb1, 0.0F, tb2, 0.0F, tb3, 0.001F, tb4, 0.0F, tb5, 0.0F, tb7, 0.06F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {
                    //valor en pulg3
                    float volumen_vTb7 = float.Parse(tb7.Text);
                    calcularValores(volumen_vTb7, tb1, 0.0F, tb2, 0.004F, tb3, 0.02F, tb4, 0.0F, tb5, 0.0F, tb6, 16.38F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb8.Text != "")
                {
                    //valor en yarda3
                    float volumen_vTb8 = float.Parse(tb8.Text);
                    calcularValores(volumen_vTb8, tb1, 0.77F, tb2, 201.97F, tb3, 764.55F, tb4, 4.81F, tb5, 27.0F, tb6, 764554.86F, tb7, 46656.0F, tb9, 0.0F);
                }
                else if (tb9.Text != "")
                {
                    //valor en acrepie
                    float volumen_vTb9 = float.Parse(tb9.Text);
                    calcularValores(volumen_vTb9, tb1, 1233.48F, tb2, 325851.4F, tb3, 1233481.8F, tb4, 7758.37F, tb5, 43560.0F, tb6, 1233481843.31F, tb7, 75271680.35F, tb8, 1613.33F);
                }
            }//comboBox item 2
            else if (cbUnidades.SelectedIndex == 3)
            {
                //temperatura
                if (tb1.Text != "")
                {
                    //valor en centigrados
                    float temp_vTb1 = float.Parse(tb1.Text);
                    calcularValores(temp_vTb1, tb2, 33.8F, tb3, 274.1F, tb4, 493.5F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en Fahrenheit
                    float temp_vTb2 = float.Parse(tb2.Text);
                    calcularValores(temp_vTb2, tb1, -17.2F, tb3, 255.9F, tb4, 460.7F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                { //valor en kelvin
                    float temp_vTb3 = float.Parse(tb3.Text);
                    calcularValores(temp_vTb3, tb1, -272.1F, tb2, -457.9F, tb4, 1.8F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en rankine
                    float temp_vTb4 = float.Parse(tb4.Text);
                    calcularValores(temp_vTb4, tb1, -273.1F, tb2, -458.7F, tb3, 0.6F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }

            }//comboBox item 3
            else if (cbUnidades.SelectedIndex == 4)
            {
                //presion
                if (tb1.Text != "")
                {//valor en bar
                    float presion_vTb1 = float.Parse(tb1.Text);
                    calcularValores(presion_vTb1, tb2, 14.5F, tb3, 100.0F, tb4, 0.9F, tb5, 1.02F, tb6, 750.06F, tb7, 33.4F, tb8, 1020.7F, tb9, 100000.00F);
                }
                else if (tb2.Text != "")
                {//valor en psi
                    float presion_vTb2 = float.Parse(tb2.Text);
                    calcularValores(presion_vTb2, tb1, 0.07F, tb3, 6.8F, tb4, 0.07F, tb5, 0.07F, tb6, 51.7F, tb7, 2.3F, tb8, 70.3F, tb9, 6894.7F);
                }
                else if (tb3.Text != "")
                {//valor en kPa
                    float presion_vTb3 = float.Parse(tb3.Text);
                    calcularValores(presion_vTb3, tb1, 0.01F, tb2, 0.15F, tb4, 0.01F, tb5, 0.01F, tb6, 7.5F, tb7, 0.3F, tb8, 10.2F, tb9, 1000.00F);
                }
                else if (tb4.Text != "")
                {//valor en atm
                    float presion_vTb4 = float.Parse(tb4.Text);
                    calcularValores(presion_vTb4, tb1, 1.0F, tb2, 14.7F, tb3, 101.3F, tb5, 1.0F, tb6, 760.0F, tb7, 33.9F, tb8, 1034.2F, tb9, 101325.0F);
                }
                else if (tb5.Text != "")
                {//valor en kg/cm2
                    float presion_vTb5 = float.Parse(tb5.Text);
                    calcularValores(presion_vTb5, tb1, 0.98F, tb2, 14.22F, tb3, 98.07F, tb4, 0.97F, tb6, 735.56F, tb7, 32.84F, tb8, 1000.99F, tb9, 98066.50F);
                }
                else if (tb6.Text != "")
                {//valor en mmhg
                    float presion_vTb6 = float.Parse(tb6.Text);
                    calcularValores(presion_vTb6, tb1, 0.001F, tb2, 0.019F, tb3, 0.13F, tb4, 0.001F, tb5, 0.001F, tb7, 0.045F, tb8, 1.36F, tb9, 133.32F);
                }
                else if (tb7.Text != "")
                {
                    //valor en pieagua
                    float presion_vTb7 = float.Parse(tb7.Text);
                    calcularValores(presion_vTb7, tb1, 0.03F, tb2, 0.43F, tb3, 2.99F, tb4, 0.029F, tb5, 0.03F, tb6, 22.39F, tb8, 30.48F, tb9, 2986.12F);
                }
                else if (tb8.Text != "")
                {
                    //valor en cmagua
                    float presion_vTb8 = float.Parse(tb8.Text);
                    calcularValores(presion_vTb8, tb1, 0.001F, tb2, 0.01F, tb3, 0.098F, tb4, 0.001F, tb5, 0.001F, tb6, 0.74F, tb7, 0.03F, tb9, 97.97F);
                }
                else if (tb9.Text != "")
                {
                    //valor en pa
                    float presion_vTb9 = float.Parse(tb9.Text);
                    calcularValores(presion_vTb9, tb1, 0.0F, tb2, 0.0F, tb3, 0.001F, tb4, 0.0F, tb5, 0.0F, tb6, 0.007F, tb7, 0.0F, tb8, 0.01F);
                }

            }//comboBox item 4
            else if (cbUnidades.SelectedIndex == 5)
            {
                //masa
                if (tb1.Text != "")
                {//valor en kg
                    float masa_vTb1 = float.Parse(tb1.Text);
                    calcularValores(masa_vTb1, tb2, 2.2F, tb3, 1000.0F, tb4, 1000000.0F, tb5, 35.27F, tb6, 0.06F, tb7, 0.001F, tb8, 0.001F, tb9, 0.001F);
                }
                else if (tb2.Text != "")
                {
                    //valor en lb
                    float masa_vTb2 = float.Parse(tb2.Text);
                    calcularValores(masa_vTb2, tb1, 0.45F, tb3, 453.59F, tb4, 453592.37F, tb5, 16.0F, tb6, 0.03F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {
                    //valor en g
                    float masa_vTb3 = float.Parse(tb3.Text);
                    calcularValores(masa_vTb3, tb1, 0.001F, tb2, 0.002F, tb4, 1000.0F, tb5, 0.035F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {
                    //valor en mg
                    float masa_vTb4 = float.Parse(tb4.Text);
                    calcularValores(masa_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {
                    //valor en onza
                    float masa_vTb5 = float.Parse(tb5.Text);
                    calcularValores(masa_vTb5, tb1, 0.0F, tb2, 0.1F, tb3, 28.3F, tb4, 28349.5F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {
                    //valor en slug
                    float masa_vTb6 = float.Parse(tb6.Text);
                    calcularValores(masa_vTb6, tb1, 14.6F, tb2, 32.2F, tb3, 14593.9F, tb4, 14593902.9F, tb5, 514.8F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {
                    //valor en TM
                    float masa_vTb7 = float.Parse(tb7.Text);
                    calcularValores(masa_vTb7, tb1, 1000.0F, tb2, 2204.6F, tb3, 1000000.0F, tb4, 1000000000.0F, tb5, 35274.0F, tb6, 68.5F, tb8, 1.1F, tb9, 1.0F);
                }
                else if (tb8.Text != "")
                {
                    //valor en ton(us)
                    float masa_vTb8 = float.Parse(tb8.Text);
                    calcularValores(masa_vTb8, tb1, 907.2F, tb2, 2000.0F, tb3, 907184.7F, tb4, 907184739.9F, tb5, 32000.0F, tb6, 62.2F, tb7, 0.9F, tb9, 0.9F);
                }
                else if (tb9.Text != "")
                {
                    //valor en ton(UK)
                    float masa_vTb9 = float.Parse(tb9.Text);
                    calcularValores(masa_vTb9, tb1, 1016.0F, tb2, 2240.0F, tb3, 1016046.9F, tb4, 1016046908.4F, tb5, 35840.0F, tb6, 69.6F, tb7, 1.0F, tb8, 1.1F);
                }
            }//comboBox item 5
            else if (cbUnidades.SelectedIndex == 6)
            {
                //moles
                if (tb1.Text != "")
                {//valor en mol
                    float moles_vTb1 = float.Parse(tb1.Text);
                    calcularValores(moles_vTb1, tb2, 0.001F, tb3, 0.002F, tb4, 0.02F, tb5, 0.8F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en kmol
                    float moles_vTb2 = float.Parse(tb2.Text);
                    calcularValores(moles_vTb2, tb1, 1000.0F, tb3, 2.2F, tb4, 22.4F, tb5, 836.6F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en lbmol
                    float moles_vTb3 = float.Parse(tb3.Text);
                    calcularValores(moles_vTb3, tb1, 453.6F, tb2, 0.5F, tb4, 10.2F, tb5, 379.5F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en nm3
                    float moles_vTb4 = float.Parse(tb4.Text);
                    calcularValores(moles_vTb4, tb1, 44.6F, tb2, 0.04F, tb3, 0.1F, tb5, 37.3F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en scf
                    float moles_vTb5 = float.Parse(tb5.Text);
                    calcularValores(moles_vTb5, tb1, 1.19F, tb2, 0.001F, tb3, 0.003F, tb4, 0.027F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 6
            else if (cbUnidades.SelectedIndex == 7)
            {
                //densidad
                if (tb1.Text != "")
                {//valor en kg/m3
                    float densidad_vTb1 = float.Parse(tb1.Text);
                    calcularValores(densidad_vTb1, tb2, 0.06F, tb3, 0.001F, tb4, 0.001F, tb5, 0.008F, tb6, 0.0F, tb7, 141368.5F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en lb/pie3
                    float densidad_vTb2 = float.Parse(tb2.Text);
                    calcularValores(densidad_vTb2, tb1, 16.02F, tb3, 0.02F, tb4, 0.02F, tb5, 0.13F, tb6, 0.001F, tb7, 8702.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en kg/l
                    float densidad_vTb3 = float.Parse(tb3.Text);
                    calcularValores(densidad_vTb3, tb1, 1000.0F, tb2, 62.4F, tb4, 1.0F, tb5, 8.35F, tb6, 0.04F, tb7, 10.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en g/cm3
                    float densidad_vTb4 = float.Parse(tb4.Text);
                    calcularValores(densidad_vTb4, tb1, 1000.0F, tb2, 62.4F, tb3, 1.0F, tb5, 8.3F, tb6, 0.04F, tb7, 10.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en lb/gal
                    float densidad_vTb5 = float.Parse(tb5.Text);
                    calcularValores(densidad_vTb5, tb1, 119.8F, tb2, 7.5F, tb3, 0.1F, tb4, 0.1F, tb6, 0.004F, tb7, 1049.4F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en lb/pulg3
                    float densidad_vTb6 = float.Parse(tb6.Text);
                    calcularValores(densidad_vTb6, tb1, 27680.0F, tb2, 1728.0F, tb3, 27.7F, tb4, 27.7F, tb5, 231.0F, tb7, -126.4F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {//valor en api
                    float densidad_vTb7 = float.Parse(tb7.Text);
                    calcularValores(densidad_vTb7, tb1, 1067.92F, tb2, 66.67F, tb3, 1.07F, tb4, 1.07F, tb5, 8.91F, tb6, 0.04F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 7
            else if (cbUnidades.SelectedIndex == 8)
            {
                //energia
                if (tb1.Text != "")
                {//valor en kj
                    float energia_vTb1 = float.Parse(tb1.Text);
                    calcularValores(energia_vTb1, tb2, 0.2F, tb3, 0.9F, tb4, 0.0F, tb5, 1.3F, tb6, 737.6F, tb7, 102.0F, tb8, 1000.0F, tb9, 239.0F);
                }
                else if (tb2.Text != "")
                {//valor en kcal
                    float energia_vTb2 = float.Parse(tb2.Text);
                    calcularValores(energia_vTb2, tb1, 4.2F, tb3, 4.0F, tb4, 0.001F, tb5, 5.6F, tb6, 3086.0F, tb7, 426.7F, tb8, 4184.0F, tb9, 1000.0F);
                }
                else if (tb3.Text != "")
                {//valor en btu
                    float energia_vTb3 = float.Parse(tb3.Text);
                    calcularValores(energia_vTb3, tb1, 1.1F, tb2, 0.3F, tb4, 0.0F, tb5, 1.4F, tb6, 777.6F, tb7, 107.5F, tb8, 1054.4F, tb9, 252.0F);
                }
                else if (tb4.Text != "")
                {//valor en kw
                    float energia_vTb4 = float.Parse(tb4.Text);
                    calcularValores(energia_vTb4, tb1, 3600.0F, tb2, 860.4F, tb3, 3414.4F, tb5, 4827.7F, tb6, 2655217.5F, tb7, 367098.9F, tb8, 3599997.1F, tb9, 860420.0F);
                }
                else if (tb5.Text != "")
                {//valor en hp]]
                    float energia_vTb5 = float.Parse(tb5.Text);
                    calcularValores(energia_vTb5, tb1, 0.7F, tb2, 0.2F, tb3, 0.7F, tb4, 0.0F, tb6, 550.0F, tb7, 76.0F, tb8, 745.7F, tb9, 178.2F);
                }
                else if (tb6.Text != "")
                {//valor en lbf
                    float energia_vTb6 = float.Parse(tb6.Text);
                    calcularValores(energia_vTb6, tb1, 0.001F, tb2, 0.0F, tb3, 0.001F, tb4, 0.0F, tb5, 0.002F, tb7, 0.1F, tb8, 1.4F, tb9, 0.3F);
                }
                else if (tb7.Text != "")
                {//valor en kgf
                    float energia_vTb7 = float.Parse(tb7.Text);
                    calcularValores(energia_vTb7, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 7.2F, tb8, 9.8F, tb9, 2.3F);
                }
                else if (tb8.Text != "")
                {//valor en j
                    float energia_vTb8 = float.Parse(tb8.Text);
                    calcularValores(energia_vTb8, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.7F, tb7, 0.1F, tb9, 0.2F);
                }
                else if (tb9.Text != "")
                {//valor en cal
                    float energia_vTb9 = float.Parse(tb9.Text);
                    calcularValores(energia_vTb9, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 3.1F, tb7, 0.4F, tb8, 4.2F);
                }
            }//else 8
            else if (cbUnidades.SelectedIndex == 9)
            {
                //potencia
                if (tb1.Text != "")
                {//valor en kw
                    float potencia_vTb1 = float.Parse(tb1.Text);
                    calcularValores(potencia_vTb1, tb2, 1.3F, tb3, 860.4F, tb4, 3414.4F, tb5, 102.0F, tb6, 737.6F, tb7, 1000.0F, tb8, 0.9F, tb9, 239.0F);
                }
                else if (tb2.Text != "")
                {//valor en hp
                    float potencia_vTb2 = float.Parse(tb2.Text);
                    calcularValores(potencia_vTb2, tb1, 0.7F, tb3, 641.6F, tb4, 2546.1F, tb5, 76.0F, tb6, 550.0F, tb7, 745.7F, tb8, 0.7F, tb9, 178.2F);
                }
                else if (tb3.Text != "")
                {//valor en kcalh
                    float potencia_vTb3 = float.Parse(tb3.Text);
                    calcularValores(potencia_vTb3, tb1, 0.0F, tb2, 0.0F, tb4, 4.0F, tb5, 0.1F, tb6, 0.9F, tb7, 1.2F, tb8, 0.0F, tb9, 0.3F);
                }
                else if (tb4.Text != "")
                {//valor en btuh
                    float potencia_vTb4 = float.Parse(tb4.Text);
                    calcularValores(potencia_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.3F, tb5, 0.0F, tb6, 0.2F, tb7, 0.3F, tb8, 0.0F, tb9, 0.1F);
                }
                else if (tb5.Text != "")
                {//valor en kgfms
                    float potencia_vTb5 = float.Parse(tb5.Text);
                    calcularValores(potencia_vTb5, tb1, 0.0F, tb2, 0.0F, tb3, 8.4F, tb4, 33.5F, tb6, 7.2F, tb7, 9.8F, tb8, 0.0F, tb9, 2.3F);
                }
                else if (tb6.Text != "")
                {//valor en lbfpies
                    float potencia_vTb6 = float.Parse(tb6.Text);
                    calcularValores(potencia_vTb6, tb1, 0.0F, tb2, 0.0F, tb3, 1.2F, tb4, 4.6F, tb5, 0.1F, tb7, 1.4F, tb8, 0.0F, tb9, 0.3F);
                }
                else if (tb7.Text != "")
                {//valor en w
                    float potencia_vTb7 = float.Parse(tb7.Text);
                    calcularValores(potencia_vTb7, tb1, 0.0F, tb2, 0.0F, tb3, 0.9F, tb4, 3.4F, tb5, 0.1F, tb6, 0.7F, tb8, 0.0F, tb9, 0.2F);
                }
                else if (tb8.Text != "")
                {//valor en btu
                    float potencia_vTb8 = float.Parse(tb8.Text);
                    calcularValores(potencia_vTb8, tb1, 1.1F, tb2, 1.4F, tb3, 907.2F, tb4, 3600.0F, tb5, 107.5F, tb6, 777.6F, tb7, 1054.4F, tb9, 252.0F);
                }
                else if (tb9.Text != "")
                {//valor en cal
                    float potencia_vTb9 = float.Parse(tb9.Text);
                    calcularValores(potencia_vTb9, tb1, 0.0F, tb2, 0.0F, tb3, 3.6F, tb4, 14.3F, tb5, 0.4F, tb6, 3.1F, tb7, 4.2F, tb8, 0.0F);
                }
            }//else 9
            else if (cbUnidades.SelectedIndex == 10)
            {
                //flujo volumetrico
                if (tb1.Text != "")
                {//valor en m3s
                    float flujoVolume_vTb1 = float.Parse(tb1.Text);
                    calcularValores(flujoVolume_vTb1, tb2, 2118.9F, tb3, 35.3F, tb4, 15850.3F, tb5, 543439.7F, tb6, 3600.0F, tb7, 60000.0F, tb8, 1000.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en cfm
                    float flujoVolume_vTb2 = float.Parse(tb2.Text);
                    calcularValores(flujoVolume_vTb2, tb1, 0.0F, tb3, 0.0F, tb4, 15.0F, tb5, 512.9F, tb6, 3.4F, tb7, 56.6F, tb8, 0.9F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en pie3s
                    float flujoVolume_vTb3 = float.Parse(tb3.Text);
                    calcularValores(flujoVolume_vTb3, tb1, 0.0F, tb2, 60.0F, tb4, 448.8F, tb5, 15388.5F, tb6, 101.9F, tb7, 1699.0F, tb8, 28.3F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en gpm
                    float flujoVolume_vTb4 = float.Parse(tb4.Text);
                    calcularValores(flujoVolume_vTb4, tb1, 0.0F, tb2, 0.1F, tb3, 0.0F, tb5, 34.3F, tb6, 0.2F, tb7, 3.8F, tb8, 0.1F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en bd
                    float flujoVolume_vTb5 = float.Parse(tb5.Text);
                    calcularValores(flujoVolume_vTb5, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb6, 0.0F, tb7, 0.1F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en m3h
                    float flujoVolume_vTb6 = float.Parse(tb6.Text);
                    calcularValores(flujoVolume_vTb6, tb1, 0.0F, tb2, 0.6F, tb3, 0.0F, tb4, 4.4F, tb5, 151.0F, tb7, 16.7F, tb8, 0.3F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {//valor en lmin
                    float flujoVolume_vTb7 = float.Parse(tb7.Text);
                    calcularValores(flujoVolume_vTb7, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.3F, tb5, 9.1F, tb6, 0.1F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb8.Text != "")
                {//valor en ls
                    float flujoVolume_vTb8 = float.Parse(tb8.Text);
                    calcularValores(flujoVolume_vTb8, tb1, 0.0F, tb2, 2.1F, tb3, 0.0F, tb4, 15.9F, tb5, 543.4F, tb6, 3.6F, tb7, 60.0F, tb9, 0.0F);
                }
            }//else 10
            else if (cbUnidades.SelectedIndex == 11)
            {
                //flujo masico
                if (tb1.Text != "")
                {//valor en kgs
                    float flujoMasico_vTb1 = float.Parse(tb1.Text);
                    calcularValores(flujoMasico_vTb1, tb2, 3600.0F, tb3, 1000.0F, tb4, 3.6F, tb5, 86.4F, tb6, 2.2F, tb7, 7936.6F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en kgh
                    float flujoMasico_vTb2 = float.Parse(tb2.Text);
                    calcularValores(flujoMasico_vTb2, tb1, 0.0F, tb3, 0.3F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 2.2F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en gs
                    float flujoMasico_vTb3 = float.Parse(tb3.Text);
                    calcularValores(flujoMasico_vTb3, tb1, 0.0F, tb2, 3.6F, tb4, 0.0F, tb5, 0.1F, tb6, 0.0F, tb7, 7.9F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en tmh
                    float flujoMasico_vTb4 = float.Parse(tb4.Text);
                    calcularValores(flujoMasico_vTb4, tb1, 0.3F, tb2, 1000.0F, tb3, 277.8F, tb5, 24.0F, tb6, 0.6F, tb7, 2204.6F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en tmd
                    float flujoMasico_vTb5 = float.Parse(tb5.Text);
                    calcularValores(flujoMasico_vTb5, tb1, 0.0F, tb2, 41.7F, tb3, 11.6F, tb4, 0.0F, tb6, 0.0F, tb7, 91.9F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en lbs
                    float flujoMasico_vTb6 = float.Parse(tb6.Text);
                    calcularValores(flujoMasico_vTb6, tb1, 0.5F, tb2, 1632.9F, tb3, 453.6F, tb4, 1.6F, tb5, 39.2F, tb7, 3600.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {//valor en lbh
                    float flujoMasico_vTb7 = float.Parse(tb7.Text);
                    calcularValores(flujoMasico_vTb7, tb1, 0.0F, tb2, 0.5F, tb3, 0.1F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 11
            else if (cbUnidades.SelectedIndex == 12)
            {
                //flujo molar
                if (tb1.Text != "")
                {//valor en mols
                    float flujoMolar_vTb1 = float.Parse(tb1.Text);
                    calcularValores(flujoMolar_vTb1, tb2, 0.0F, tb3, 3.6F, tb4, 0.0F, tb5, 7.9F, tb6, 80.7F, tb7, 0.1F, tb8, 3011.8F, tb9, 5.2F);
                }
                else if (tb2.Text != "")
                {//valor en kmols
                    float flujoMolar_vTb2 = float.Parse(tb2.Text);
                    calcularValores(flujoMolar_vTb2, tb1, 1000.0F, tb3, 3600.0F, tb4, 2.2F, tb5, 7936.6F, tb6, 80690.8F, tb7, 80.7F, tb8, 3011846.4F, tb9, 50197.4F);
                }
                else if (tb3.Text != "")
                {//valor en kmolh
                    float flujoMolar_vTb3 = float.Parse(tb3.Text);
                    calcularValores(flujoMolar_vTb3, tb1, 0.3F, tb2, 0.0F, tb4, 0.0F, tb5, 2.2F, tb6, 22.4F, tb7, 0.0F, tb8, 836.6F, tb9, 13.9F);
                }
                else if (tb4.Text != "")
                {//valor en lbmols
                    float flujoMolar_vTb4 = float.Parse(tb4.Text);
                    calcularValores(flujoMolar_vTb4, tb1, 453.6F, tb2, 0.5F, tb3, 1632.9F, tb5, 3600.0F, tb6, 36600.7F, tb7, 36.6F, tb8, 1366150.3F, tb9, 22769.2F);
                }
                else if (tb5.Text != "")
                {//valor en lbmolh
                    float flujoMolar_vTb5 = float.Parse(tb5.Text);
                    calcularValores(flujoMolar_vTb5, tb1, 0.1F, tb2, 0.0F, tb3, 0.5F, tb4, 0.0F, tb6, 10.2F, tb7, 0.0F, tb8, 379.5F, tb9, 6.3F);
                }
                else if (tb6.Text != "")
                {//valor en nm3h
                    float flujoMolar_vTb6 = float.Parse(tb6.Text);
                    calcularValores(flujoMolar_vTb6, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.1F, tb7, 0.0F, tb8, 37.3F, tb9, 0.6F);
                }
                else if (tb7.Text != "")
                {//valor en nlh
                    float flujoMolar_vTb7 = float.Parse(tb7.Text);
                    calcularValores(flujoMolar_vTb7, tb1, 12.4F, tb2, 0.0F, tb3, 44.6F, tb4, 0.0F, tb5, 98.4F, tb6, 1000.0F, tb8, 37325.8F, tb9, 622.1F);
                }
                else if (tb8.Text != "")
                {//valor en scfh
                    float flujoMolar_vTb8 = float.Parse(tb8.Text);
                    calcularValores(flujoMolar_vTb8, tb1, 0.0F, tb2, 0.0F, tb3, 0.001F, tb4, 0.000F, tb5, 0.003F, tb6, 0.027F, tb7, 0.0F, tb9, 0.02F);
                }
                else if (tb9.Text != "")
                {//valor en scfm
                    float flujoMolar_vTb9 = float.Parse(tb9.Text);
                    calcularValores(flujoMolar_vTb9, tb1, 0.02F, tb2, 0.00F, tb3, 0.07F, tb4, 0.00F, tb5, 0.16F, tb6, 1.61F, tb7, 0.00F, tb8, 60.00F);
                }
            }//else 12
            else if (cbUnidades.SelectedIndex == 13)
            {
                //velocidad
                if (tb1.Text != "")
                {//valor en ms
                    float velocidad_vTb1 = float.Parse(tb1.Text);
                    calcularValores(velocidad_vTb1, tb2, 3.60F, tb3, 2.24F, tb4, 1.94F, tb5, 3.28F, tb6, 100.0F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
                else if (tb2.Text != "")
                {//valor en kmh
                    float velocidad_vTb2 = float.Parse(tb2.Text);
                    calcularValores(velocidad_vTb2, tb1, 0.28F, tb3, 0.62F, tb4, 0.54F, tb5, 0.91F, tb6, 27.78F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
                else if (tb3.Text != "")
                {//valor en mph
                    float velocidad_vTb3 = float.Parse(tb3.Text);
                    calcularValores(velocidad_vTb3, tb1, 0.45F, tb2, 1.61F, tb4, 0.87F, tb5, 1.47F, tb6, 44.7F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
                else if (tb4.Text != "")
                {//valor en nudo
                    float velocidad_vTb4 = float.Parse(tb4.Text);
                    calcularValores(velocidad_vTb4, tb1, 0.51F, tb2, 1.85F, tb3, 1.15F, tb5, 1.69F, tb6, 51.44F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
                else if (tb5.Text != "")
                {//valor en pies
                    float velocidad_vTb5 = float.Parse(tb5.Text);
                    calcularValores(velocidad_vTb5, tb1, 0.30F, tb2, 1.10F, tb3, 0.68F, tb4, 0.59F, tb6, 30.48F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
                else if (tb6.Text != "")
                {//valor en cms
                    float velocidad_vTb6 = float.Parse(tb6.Text);
                    calcularValores(velocidad_vTb6, tb1, 0.01F, tb2, 0.04F, tb3, 0.02F, tb4, 0.02F, tb5, 0.003F, tb7, 0.0f, tb8, 0.0f, tb9, 0.0f);
                }
            }//else 13
            else if (cbUnidades.SelectedIndex == 14)
            {
                //viscocidad cinematica
                if (tb1.Text != "")
                {//valor en m2s
                    float viscoCine_vTb1 = float.Parse(tb1.Text);
                    calcularValores(viscoCine_vTb1, tb2, 10.8F, tb3, 10000.0F, tb4, 1000000.0F, tb5, 36000000.0F, tb6, 38750.1F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en pie2s
                    float viscoCine_vTb2 = float.Parse(tb2.Text);
                    calcularValores(viscoCine_vTb2, tb1, 0.1F, tb3, 929.0F, tb4, 92903.0F, tb5, 3344509.4F, tb6, 3600.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en st
                    float viscoCine_vTb3 = float.Parse(tb3.Text);
                    calcularValores(viscoCine_vTb3, tb1, 0.0F, tb2, 0.0F, tb4, 100.0F, tb5, 3600.0F, tb6, 3.9F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en cst
                    float viscoCine_vTb4 = float.Parse(tb4.Text);
                    calcularValores(viscoCine_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb5, 36.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en cm2h
                    float viscoCine_vTb5 = float.Parse(tb5.Text);
                    calcularValores(viscoCine_vTb5, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.028F, tb6, 0.001F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en pie2h
                    float viscoCine_vTb = float.Parse(tb6.Text);
                    calcularValores(viscoCine_vTb, tb1, 0.0F, tb2, 0.0F, tb3, 0.3F, tb4, 25.8F, tb5, 929.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 14
            else if (cbUnidades.SelectedIndex == 15)
            {
                //viscocidad dinamica
                if (tb1.Text != "")
                {//valor en kgms
                    float viscoDinamica_vTb1 = float.Parse(tb1.Text);
                    calcularValores(viscoDinamica_vTb1, tb2, 0.7F, tb3, 10.0F, tb4, 1000.0F, tb5, 1.0F, tb6, 2419.1F, tb7, 10.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en lbpie
                    float viscoDinamica_vTb2 = float.Parse(tb2.Text);
                    calcularValores(viscoDinamica_vTb2, tb1, 1.5F, tb3, 14.9F, tb4, 1488.2F, tb5, 1.5F, tb6, 3600.0F, tb7, 14.9F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en p
                    float viscoDinamica_vTb3 = float.Parse(tb3.Text);
                    calcularValores(viscoDinamica_vTb3, tb1, 0.1F, tb2, 0.1F, tb4, 100.0F, tb5, 0.1F, tb6, 241.9F, tb7, 1.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en cp
                    float viscoDinamica_vTb4 = float.Parse(tb4.Text);
                    calcularValores(viscoDinamica_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.01F, tb5, 0.0F, tb6, 2.42F, tb7, 0.01F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en pas
                    float viscoDinamica_vTb5 = float.Parse(tb5.Text);
                    calcularValores(viscoDinamica_vTb5, tb1, 1.0F, tb2, 0.7F, tb3, 10.0F, tb4, 1000.0F, tb6, 2419.1F, tb7, 10.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en lbpieh
                    float viscoDinamica_vTb6 = float.Parse(tb6.Text);
                    calcularValores(viscoDinamica_vTb6, tb1, 0.0F, tb2, 0.0F, tb3, 0.0F, tb4, 0.41F, tb5, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb7.Text != "")
                {//valor en gcms
                    float viscoDinamica_vTb7 = float.Parse(tb7.Text);
                    calcularValores(viscoDinamica_vTb7, tb1, 0.1F, tb2, 0.1F, tb3, 1.0F, tb4, 100.0F, tb5, 0.1F, tb6, 241.9F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 15
            else if (cbUnidades.SelectedIndex == 16)
            {
                //conductividad termica
                if (tb1.Text != "")
                {//valor en 
                    float conducTermica_vTb1 = float.Parse(tb1.Text);
                    calcularValores(conducTermica_vTb1, tb2, 2.4F, tb3, 578.2F, tb4, 1000.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en 
                    float conducTermica_vTb2 = float.Parse(tb2.Text);
                    calcularValores(conducTermica_vTb2, tb1, 0.4F, tb3, 241.9F, tb4, 418.4F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en 
                    float conducTermica_vTb3 = float.Parse(tb3.Text);
                    calcularValores(conducTermica_vTb3, tb1, 0.002F, tb2, 0.004F, tb4, 1.7F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en 
                    float conducTermica_vTb4 = float.Parse(tb4.Text);
                    calcularValores(conducTermica_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.6F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 16
            else if (cbUnidades.SelectedIndex == 17)
            {
                //coef tans de calor
                if (tb1.Text != "")
                {//valor en w
                    float coefTransCalor_vTb1 = float.Parse(tb1.Text);
                    calcularValores(coefTransCalor_vTb1, tb2, 0.9F, tb3, 0.2F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en kcal
                    float coefTransCalor_vTb2 = float.Parse(tb2.Text);
                    calcularValores(coefTransCalor_vTb2, tb1, 1.2F, tb3, 0.2F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en btu
                    float coefTransCalor_vTb3 = float.Parse(tb3.Text);
                    calcularValores(coefTransCalor_vTb3, tb1, 5.7F, tb2, 4.9F, tb4, 0.0F, tb5, 0.01F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en cal
                    float coefTransCalor_vTb4 = float.Parse(tb4.Text);
                    calcularValores(coefTransCalor_vTb4, tb1, 41839.9F, tb2, 36000.0F, tb3, 7368.4F, tb5, 41.8F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en kw
                    float coefTransCalor_vTb5 = float.Parse(tb5.Text);
                    calcularValores(coefTransCalor_vTb5, tb1, 1000.0F, tb2, 860.4F, tb3, 176.1F, tb4, 0.02F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 17
            else if (cbUnidades.SelectedIndex == 18)
            {
                //entalpia especifica
                if (tb1.Text != "")
                {//valor en kj
                    float entalpiaEspe_vTb1 = float.Parse(tb1.Text);
                    calcularValores(entalpiaEspe_vTb1, tb2, 1.0F, tb3, 1000.0F, tb4, 0.2F, tb5, 0.4F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en j/g
                    float entalpiaEspe_vTb2 = float.Parse(tb2.Text);
                    calcularValores(entalpiaEspe_vTb2, tb1, 1.0F, tb3, 1000.0F, tb4, 0.2F, tb5, 0.4F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en j/kg
                    float entalpiaEspe_vTb3 = float.Parse(tb3.Text);
                    calcularValores(entalpiaEspe_vTb3, tb1, 0.0F, tb2, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en cal/g
                    float entalpiaEspe_vTb4 = float.Parse(tb4.Text);
                    calcularValores(entalpiaEspe_vTb4, tb1, 4.2F, tb2, 4.2F, tb3, 4184.0F, tb5, 1.8F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en btu/lb
                    float entalpiaEspe_vTb5 = float.Parse(tb5.Text);
                    calcularValores(entalpiaEspe_vTb5, tb1, 2.3F, tb2, 2.3F, tb3, 2326.0F, tb4, 0.6F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 18
            else if (cbUnidades.SelectedIndex == 19)
            {
                //entropia especifica
                if (tb1.Text != "")
                {//valor en 
                    float entropiaEspe_vTb1 = float.Parse(tb1.Text);
                    calcularValores(entropiaEspe_vTb1, tb2, 1000.0F, tb3, 0.2F, tb4, 0.2F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en 
                    float entropiaEspe_vTb2 = float.Parse(tb2.Text);
                    calcularValores(entropiaEspe_vTb2, tb1, 0.001F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en 
                    float entropiaEspe_vTb3 = float.Parse(tb3.Text);
                    calcularValores(entropiaEspe_vTb3, tb1, 4.2F, tb2, 4184.0F, tb4, 1.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en 
                    float entropiaEspe_vTb4 = float.Parse(tb4.Text);
                    calcularValores(entropiaEspe_vTb4, tb1, 4.2F, tb2, 4184.0F, tb3, 1.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 19
            else if (cbUnidades.SelectedIndex == 20)
            {
                //volumen especifico
                if (tb1.Text != "")
                {//valor en m3/kg
                    float volumenEsp_vTb1 = float.Parse(tb1.Text);
                    calcularValores(volumenEsp_vTb1, tb2, 1000.0F, tb3, 16.0F, tb4, 27679.9F, tb5, 119.8F, tb6, 1000.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en cm3/g
                    float volumenEsp_vTb2 = float.Parse(tb2.Text);
                    calcularValores(volumenEsp_vTb2, tb1, 0.0F, tb3, 0.0F, tb4, 27.7F, tb5, 0.1F, tb6, 1.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en pie3/lb
                    float volumenEsp_vTb3 = float.Parse(tb3.Text);
                    calcularValores(volumenEsp_vTb3, tb1, 0.1F, tb2, 62.4F, tb4, 1728.0F, tb5, 7.5F, tb6, 62.4F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en pulg3/lb
                    float volumenEsp_vTb4 = float.Parse(tb4.Text);
                    calcularValores(volumenEsp_vTb4, tb1, 0.0F, tb2, 0.04F, tb3, 0.0F, tb5, 0.0F, tb6, 0.04F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en gal/lb
                    float volumenEsp_vTb5 = float.Parse(tb5.Text);
                    calcularValores(volumenEsp_vTb5, tb1, 0.01F, tb2, 8.3F, tb3, 0.1F, tb4, 231.0F, tb6, 8.3F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb6.Text != "")
                {//valor en l/kg
                    float volumenEsp_vTb6 = float.Parse(tb6.Text);
                    calcularValores(volumenEsp_vTb6, tb1, 0.0F, tb2, 1.0F, tb3, 0.02F, tb4, 27.7F, tb5, 0.1F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 20
            else if (cbUnidades.SelectedIndex == 21)
            {
                //angulo plano
                if (tb1.Text != "")
                {//valor en grados
                    float anguloPlano_vTb1 = float.Parse(tb1.Text);
                    calcularValores(anguloPlano_vTb1, tb2, 0.01F, tb3, 60.0F, tb4, 3600.0F, tb5, 0.003F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en radianes
                    float anguloPlano_vTb2 = float.Parse(tb2.Text);
                    calcularValores(anguloPlano_vTb2, tb1, 57.3F, tb3, 3437.7F, tb4, 206264.8F, tb5, 0.2F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en min
                    float anguloPlano_vTb3 = float.Parse(tb3.Text);
                    calcularValores(anguloPlano_vTb3, tb1, 0.02F, tb2, 0.0F, tb4, 60.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en seg
                    float anguloPlano_vTb4 = float.Parse(tb4.Text);
                    calcularValores(anguloPlano_vTb4, tb1, 0.0F, tb2, 0.0F, tb3, 0.02F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en revoluciones
                    float anguloPlano_vTb5 = float.Parse(tb5.Text);
                    calcularValores(anguloPlano_vTb5, tb1, 360.0F, tb2, 6.3F, tb3, 21600.0F, tb4, 1295999.9F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 21
            else if (cbUnidades.SelectedIndex == 22)
            {
                //tiempo
                if (tb1.Text != "")
                {//valor en seg
                    float tiempo_vTb1 = float.Parse(tb1.Text);
                    calcularValores(tiempo_vTb1, tb2, 0.01F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en min
                    float tiempo_vTb2 = float.Parse(tb2.Text);
                    calcularValores(tiempo_vTb2, tb1, 60.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en h
                    float tiempo_vTb3 = float.Parse(tb3.Text);
                    calcularValores(tiempo_vTb3, tb1, 3600.0F, tb2, 60.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en dia
                    float tiempo_vTb4 = float.Parse(tb4.Text);
                    calcularValores(tiempo_vTb4, tb1, 86400.0F, tb2, 1440.0F, tb3, 24.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb5.Text != "")
                {//valor en año
                    float tiempo_vTb5 = float.Parse(tb5.Text);
                    calcularValores(tiempo_vTb5, tb1, 31536000.0F, tb2, 525600.0F, tb3, 8760.0F, tb4, 365.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 22
            else if (cbUnidades.SelectedIndex == 23)
            {
                //fuerza
                if (tb1.Text != "")
                {//valor en n
                    float fuerza_vTb1 = float.Parse(tb1.Text);
                    calcularValores(fuerza_vTb1, tb2, 100000.0F, tb3, 0.2F, tb4, 0.1F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb2.Text != "")
                {//valor en dina
                    float fuerza_vTb2 = float.Parse(tb2.Text);
                    calcularValores(fuerza_vTb2, tb1, 0.0F, tb3, 0.0F, tb4, 0.0F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb3.Text != "")
                {//valor en lbf
                    float fuerza_vTb3 = float.Parse(tb3.Text);
                    calcularValores(fuerza_vTb3, tb1, 4.4F, tb2, 444822.2F, tb4, 0.5F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
                else if (tb4.Text != "")
                {//valor en kgf
                    float fuerza_vTb4 = float.Parse(tb4.Text);
                    calcularValores(fuerza_vTb4, tb1, 9.8F, tb2, 980665.2F, tb3, 2.2F, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                }
            }//else 23
        }//fin comboBox
        public void validarDatos(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                val = 1;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                val = 1;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
                val = 1;
            }
            else
            {
                e.Handled = true;
                val = 0;
                lMsjError.Visible = true;
                lMsjError.Text = "Solo se admiten números";
                //    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nroDecimales_SelectedItemChanged(object sender, EventArgs e)
        {
            Formato = GetFormato(int.Parse(nroDecimales.Text));
        }

        private string GetFormato(int v) => Enumerable.Range(0, v).Aggregate("0.", (s, i) => $"{s}0");

        private string GetFormato2(int v)
        {
            string cad = "";
            for (int i = 0; i < v; i++)
                cad += "0";
            return "0." + cad;
        }

    }
}



