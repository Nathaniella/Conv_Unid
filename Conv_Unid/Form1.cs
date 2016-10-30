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
            }
            else if (cbUnidades.SelectedIndex == 1)
            {//area
                cambiarLabels("m2", "pie2", "km2", "milla2", "acre", "hectárea", "pulg2", "cm2", "yarda2");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 2)
            { //volumen
                cambiarLabels("m3", "gal(US)", "L", "barril(US)", "pie3", "cm3", "pulg3", "yarda3", "acre pie");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 3)
            {//temperatura
                cambiarLabels("ºC"
                , "ºF"
                , "ºK"
                , "ºR(Rankine)"
                , ""
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 4)
            {//presion
                cambiarLabels("bar", "psi", "kPa", "atm", "kg/cm2", "mm Hg(torr)", "pie agua", "cm agua", "Pa(N/m2)");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 5)
            {//masa
                cambiarLabels("kg", "lb", "g", "mg", "onza", "slug", "TM(tonne)", "Ton(US)", "Ton(UK)");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 6)
            {//moles
                cambiarLabels("mol", "kmol", "lbmol", "N m3", "scf", "", "", "", "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible =  true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 7)
            {//densidad
                cambiarLabels("kg/m3", "lb/pie3", "kg/L", "g/cm3", "lb/gal",

                 "lb/pulg3"
                , "API"
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 8)
            {//energia
                cambiarLabels("kJ",
                "kcal",
                "Btu",
                "kW h",
                "HP s",
                "lbf pie",
                "kgf m",
                "J",
                "cal");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 9)
            {//potencia
                cambiarLabels("kW",
                "HP",
                "kcal/h",
                "Btu/h",
                "kgf m/s",
                "lbf pie/s",
                "W(J/s)",
                "Btu/s",
                "cal/s");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 10)
            {//flujo volumetrico
                cambiarLabels("m3/s"
                , "CFM"
                , "pie3/s"
                , "GPM"
                , "b/d(bpsd)"
                , "m3/h"
                , "L/min"
                , "L/s"
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = true;
                tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 11)
            {//flujo masico
                cambiarLabels("kg/s"
                , "kg/h"
                , "g/s"
                , "TM/h"
                , "TM/d"
                , "lb/s"
                , "lb/h"
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 12)
            {//flujo molar
                cambiarLabels("mol/s"
                 , "kmol/s"
                 , "kmol/h"
                 , "lbmol/s"
                 , "lbmol/h"
                 , "N m3/h"
                 , "N L/h"
                 , "scf/h"
                 , "SCFM");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = true;
            }
            else if (cbUnidades.SelectedIndex == 13)
            {//velocidad
                cambiarLabels("m/s"
                , "km/h"
                , "MPH"
                , "nudo"
                , "pie/s"
                , "cm/s"
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 14)
            { //visco cinematica
                cambiarLabels("m2/s"
                , "pie2/s"
                , "st(cm2/s)"
                , "cSt"
                , "cm2/h"
                , "pie2/h"
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible  = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 15)
            {//visco dinamica
                cambiarLabels("kg/m s"
                , "lb/pie s"
                , "P(g/cm s)"
                , "cP"
                , "Pa s"
                , "lb/pie h"
                , "g/cm s"
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = tb7.Visible = true;
                tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 16)
            {//cond termica
                cambiarLabels("kW/m K"
                , "cal/s cm ºC"
                , "Btu/h pie ºF"
                , "W/m K"
                , ""
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 17)
            {//coef transf de calor
                cambiarLabels("W/m2 K"
                , "Kcal/h m2 ºC"
                , "Btu/h pie2 ºF"
                , "cal/s cm2 ºC"
                , "kW/m2 ºC"
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 18)
            {//entalpia especifica
                cambiarLabels("kJ/kg"
                , "J/g"
                , "J/kg"
                , "cal/g"
                , "Btu/lb"
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 19)
            {//entropia especif
                cambiarLabels("kJ/kg K"
                , "J/kg K"
                , "cal/g ºC"
                , "Btu/lb ºF"
                , ""
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 20)
            {//vol especif
                cambiarLabels("m3/kg"
                , "cm3/g"
                , "pie3/lb"
                , "pulg3/lb"
                , "gal(US)/lb"
                , "L/kg"
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 21)
            {//angulo plano
                cambiarLabels("º(grados)"
                , "radianes"
                , "'(minutos)"
                , "''(segundos)"
                , "revoluciones"
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = true;
                tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 22)
            {//tiempo
                cambiarLabels("seg"
                , "min"
                , "horas"
                , "día"
                , "año(365días)"
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = tb5.Visible = tb6.Visible = true;
                tb7.Visible = tb8.Visible = tb9.Visible = false;
            }
            else if (cbUnidades.SelectedIndex == 23)
            {//fuerza
                cambiarLabels("N"
                , "dina"
                , "lbf"
                , "kgf"
                , ""
                , ""
                , ""
                , ""
                , "");
                tb1.Visible = tb2.Visible = tb3.Visible = tb4.Visible = true;
                tb5.Visible = tb6.Visible = tb7.Visible = tb8.Visible = tb9.Visible = false;

            }
            //Realizar los calculos 
            if (cbUnidades.SelectedIndex == 0)
            { //longitud 
                //si el valor esta en metros
                if (tb1.Text != "")
                {
                    float metros = 0.3048F;
                    float pie = 3.28F;
                    float km = 1000;
                    float milla = 0.0006F;
                    float yarda = 1.0936F;
                    float pulg = 39.3701F;
                    float cm = 100;
                    float mm = 1000;
                    float micra = 1000000;
                    float vTb1 = (float)Convert.ToDouble(tb1.Text);// guardo el valor en vtb1
                    calcularValores(vTb1, tb2, pie ,tb3, km, tb4, milla, tb5, yarda, tb6, pulg, tb7, cm, tb8, mm, tb9, micra );

                    //realizo los calculos para los demas valores pieMetros es pie dado metros
                  
                }
                //si el valor esta en pies
                else if (tb2.Text != "")
                {
                    float metrosP = 0.3048F;//REVISAR
                    float kmP = 0.0003048F;
                    float millaP = 0.000189394F;
                    float yardaP = 0.33333344F;
                    float pulgP = 12;
                    float cmP = 30.48F;
                    float mmP = 304.8F;
                    float micraP = 304800F;
                    //metrosPie = calculo metros dado el valor de pie
                    float vTb2 = (float)Convert.ToDouble(tb2.Text);
                    calcularValores(vTb2, tb1, metrosP, tb3, kmP, tb4, millaP, tb5, yardaP, tb6, pulgP, tb7, cmP, tb8, mmP, tb9, micraP);

                    //float metrosPie = vTb2 * metros;
                    //tb1.Text = "" + metrosPie;
                    //float KmPies = vTb2 * kmP;
                    //tb3.Text = "" + KmPies;
                    //float millaPies = vTb2 * millaP;
                    //tb4.Text = "" + millaPies;
                    //float yardaPies = vTb2 * yardaP;
                    //tb5.Text = "" + yardaPies;
                    //float pulgPies = vTb2 * pulgP;
                    //tb6.Text = "" + pulgPies;
                    //float cmPies = vTb2 * cmP;
                    //tb7.Text = "" + cmPies;
                    //float mmPies = vTb2 * mmP;
                    //tb8.Text = "" + mmPies;
                    //float micraPies = vTb2 * micraP;
                    //tb9.Text = "" + micraPies;
                }
                //si el valor esta en km
                else if (tb3.Text != "")
                {
                    float m_Km = 1000;
                    float pie_Km = 3280.84F;
                    float milla_Km = 0.621F;
                    float yarda_Km = 1093.613F;
                    float pulg_Km = 39370;
                    float cm_Km = 100000;
                    float mm_Km = 1000000;
                    float micra_Km = 1000000000;
                    //metrosKm = calculo metros dado km
                    float vTb3 = (float)Convert.ToDouble(tb3.Text);
                    calcularValores(vTb3, tb1, m_Km, tb2, pie_Km, tb4, milla_Km, tb5, yarda_Km, tb6, pulg_Km, tb7, cm_Km, tb8, mm_Km, tb9, micra_Km);

                //    float metrosKm = vTb3 * m_Km;
                //    tb1.Text = "" + metrosKm;
                //    float pieKm = vTb3 * pie_Km;
                //    tb2.Text = "" + pieKm;
                //    float millaKm = vTb3 * milla_Km;
                //    tb4.Text = "" + millaKm;
                //    float yardaKm = vTb3 * yarda_Km;
                //    tb5.Text = "" + yardaKm;
                //    float pulgKm = vTb3 * pulg_Km;
                //    tb6.Text = "" + pulgKm;
                //    float cmKm = vTb3 * cm_Km;
                //    tb7.Text = "" + cmKm;
                //    float mmKm = vTb3 * mm_Km;
                //    tb8.Text = "" + mmKm;
                //    float micraKm = vTb3 * micra_Km;
                //    tb9.Text = "" + micraKm;
                }
                //si el valor esta en milla
                else if (tb4.Text != "")
                {
                    float m_milla = 1609.34F;
                    float pie_milla = 5280;
                    float km_milla = 1.60934F;
                    float yarda_milla = 1760;
                    float pulg_milla = 63360;
                    float cm_milla = 160934;
                    float mm_milla = 1609344.001F;
                    float micra_milla = 1609344000.615F;
                    // m_milla = milla dado los metros
                    float vTb4 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(vTb4, tb1, m_milla, tb2, pie_milla, tb3, km_milla, tb5,yarda_milla, tb6, pulg_milla, tb7, cm_milla, tb8, mm_milla, tb9, micra_milla);

                    //float mMilla = vTb4 * m_milla;
                    //tb1.Text = "" + mMilla;
                    //float pieMilla = vTb4 * pie_milla;
                    //tb2.Text = "" + pieMilla;
                    //float kmMilla = vTb4 * km_milla;
                    //tb3.Text = "" + kmMilla;
                    //float yardaMilla = vTb4 * yarda_milla;
                    //tb5.Text = "" + yardaMilla;
                    //float pulgMilla = vTb4 * pulg_milla;
                    //tb6.Text = "" + pulgMilla;
                    //float cmMilla = vTb4 * cm_milla;
                    //tb7.Text = "" + cmMilla;
                    //float mmMilla = vTb4 * mm_milla;
                    //tb8.Text = "" + mmMilla;
                    //float micraMilla = vTb4 * micra_milla;
                    //tb9.Text = "" + micraMilla;
                }
                //si el valor esta en yardas
                else if (tb5.Text != "")
                {
                    float m_yarda = 0.9144F;
                    float pie_yarda = 3.00F;
                    float km_yarda = 0.0009144F;
                    float milla_yarda = 914.4F;
                    float pulg_yarda = 36;
                    float cm_yarda = 91.44F;
                    float mm_yarda = 914.4F;
                    float micra_yarda = 914400;
                    //m_yarda = yarda dado los metros
                    float vTb5 = (float)Convert.ToDouble(tb5.Text);
                    calcularValores(vTb5, tb1, m_yarda, tb2, pie_yarda, tb3, km_yarda, tb4, milla_yarda, tb6, pulg_yarda, tb7, cm_yarda, tb8, mm_yarda, tb9, micra_yarda);

                    //float mYarda = vTb5 * m_yarda;
                    //tb1.Text = "" + mYarda;
                    //float pieYarda = vTb5 * pie_yarda;
                    //tb2.Text = "" + pieYarda;
                    //float kmYarda = vTb5 * km_yarda;
                    //tb3.Text = "" + kmYarda;
                    //float millaYarda = vTb5 * milla_yarda;
                    //tb5.Text = "" + millaYarda;
                    //float pulgYarda = vTb5 * pulg_yarda;
                    //tb6.Text = "" + pulgYarda;
                    //float cmYarda = vTb5 * cm_yarda;
                    //tb7.Text = "" + cmYarda;
                    //float mmYarda = vTb5 * mm_yarda;
                    //tb8.Text = "" + mmYarda;
                    //float micraYarda = vTb5 * micra_yarda;
                    //tb9.Text = "" + micraYarda;
                }
                //si el valor esta en pulg
                else if (tb6.Text != "")
                {
                    float m_pulg = 0.0254F;
                    float pie_pulg = 0.0833333F;
                    float km_pulg = 0.0000254F;
                    float milla_pulg = 0.000015783F;
                    float yarda_pulg = 0.0277778F;
                    float cm_pulg = 2.54F;
                    float mm_pulg = 25.4F;
                    float micra_pulg = 25400;
                    //m_pulg = m dado los pulg
                    float vTb6 = (float)Convert.ToDouble(tb6.Text);
                    calcularValores(vTb6, tb1, m_pulg, tb2, pie_pulg, tb3, km_pulg, tb4, milla_pulg, tb5, yarda_pulg, tb7, cm_pulg, tb8, mm_pulg, tb9, micra_pulg);

                    //float mPulg = vTb6 * m_pulg;
                    //tb1.Text = "" + mPulg;
                    //float piePulg = vTb6 * pie_pulg;
                    //tb2.Text = "" + piePulg;
                    //float kmPulg = vTb6 * km_pulg;
                    //tb3.Text = "" + kmPulg;
                    //float millaPulg = vTb6 * milla_pulg;
                    //tb5.Text = "" + millaPulg;
                    //float yardaPulg = vTb6 * yarda_pulg;
                    //tb6.Text = "" + yardaPulg;
                    //float cmPulg = vTb6 * cm_pulg;
                    //tb7.Text = "" + cmPulg;
                    //float mmPulg = vTb6 * mm_pulg;
                    //tb8.Text = "" + mmPulg;
                    //float micraPulg = vTb6 * micra_pulg;
                    //tb9.Text = "" + micraPulg;
                }
                //si el valor esta en cm
                else if (tb7.Text != "")
                {
                    float m_cm = 0.01F;
                    float pie_cm = 0.0328084F;
                    float km_cm = 0.000010000F;
                    float milla_cm = 0.0000062137F;
                    float yarda_cm = 0.0109361F;
                    float pulg_cm = 0.393701F;
                    float mm_cm = 10;
                    float micra_cm = 10000;
                    //m_cm = m dado los cm
                    float vTb7 = (float)Convert.ToDouble(tb7.Text);
                    calcularValores(vTb7, tb1, m_cm, tb2, pie_cm, tb3, km_cm, tb4, milla_cm, tb5, yarda_cm, tb6, pulg_cm, tb8, mm_cm, tb9, micra_cm);

                    //float mCm = vTb7 * m_cm;
                    //tb1.Text = "" + mCm;
                    //float pieCm = vTb7 * pie_cm;
                    //tb2.Text = "" + pieCm;
                    //float kmCm = vTb7 * km_cm;
                    //tb3.Text = "" + kmCm;
                    //float millaCm = vTb7 * milla_cm;
                    //tb4.Text = "" + millaCm;
                    //float yardaCm = vTb7 * yarda_cm;
                    //tb5.Text = "" + yardaCm;
                    //float pulgCm = vTb7 * pulg_cm;
                    //tb6.Text = "" + pulgCm;
                    //float mmCm = vTb7 * mm_cm;
                    //tb8.Text = "" + mmCm;
                    //float micraCm = vTb7 * micra_cm;
                    //tb9.Text = "" + micraCm;
                }
                //si el valor esta en mm
                else if (tb8.Text != "")
                {
                    float m_mm = 0.001F;
                    float pie_mm = 0.00328084F;
                    float km_mm = 0.000001000F;
                    float milla_mm = 0.00000062137F;
                    float yarda_mm = 0.00109361F;
                    float pulg_mm = 0.0393701F;
                    float cm_mm = 0.1F;
                    float micra_mm = 1000;
                    //m_mm = m dado los mm
                    float vTb8 = (float)Convert.ToDouble(tb8.Text);
                    calcularValores(vTb8, tb1, m_mm, tb2, pie_mm, tb3, km_mm, tb4, milla_mm, tb5, yarda_mm, tb6, pulg_mm, tb7, cm_mm, tb9, micra_mm);

                    //float mMm = vTb8 * m_mm;
                    //tb1.Text = "" + mMm;
                    //float pieMm = vTb8 * pie_mm;
                    //tb2.Text = "" + pieMm;
                    //float kmMm = vTb8 * km_mm;
                    //tb3.Text = "" + kmMm;
                    //float millaMm = vTb8 * milla_mm;
                    //tb4.Text = "" + millaMm;
                    //float yardaMm = vTb8 * yarda_mm;
                    //tb5.Text = "" + yardaMm;
                    //float pulgMm = vTb8 * pulg_mm;
                    //tb6.Text = "" + pulgMm;
                    //float cmMm = vTb8 * cm_mm;
                    //tb7.Text = "" + cmMm;
                    //float micraMm = vTb8 * micra_mm;
                    //tb9.Text = "" + micraMm;
                }
                //si el valor esta en micra
                else if (tb9.Text != "")
                {
                    float m_micra = 0.000001F;
                    float pie_micra = 0.0000032808F;
                    float km_micra = 0.0000000010F;
                    float milla_micra = 0.0000000006F;
                    float yarda_micra = 0.0000010936F;
                    float pulg_micra = 0.0000393701F;
                    float cm_micra = 0.0001F;
                    float mm_micra = 0.001F;
                    //m_micra = micra dado los metros
                    float vTb9 = (float)Convert.ToDouble(tb9.Text);
                    calcularValores(vTb9, tb1, m_micra, tb2, pie_micra, tb3, km_micra, tb4, milla_micra, tb5, yarda_micra, tb6, pulg_micra, tb7, cm_micra, tb8, mm_micra);

                    //float mMicra = vTb9 * m_micra;
                    //tb1.Text = "" + mMicra;
                    //float pieMicra = vTb9 * pie_micra;
                    //tb2.Text = "" + pieMicra;
                    //float kmMicra = vTb9 * km_micra;
                    //tb3.Text = "" + kmMicra;
                    //float millaMicra = vTb9 * milla_micra;
                    //tb4.Text = "" + millaMicra;
                    //float yardaMicra = vTb9 * yarda_micra;
                    //tb5.Text = "" + yardaMicra;
                    //float pulgMicra = vTb9 * pulg_micra;
                    //tb6.Text = "" + pulgMicra;
                    //float cmMicra = vTb9 * cm_micra;
                    //tb7.Text = "" + cmMicra;
                    //float mmMicra = vTb9 * mm_micra;
                    //tb8.Text = "" + mmMicra;
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
                    float pie2_m2 = 10.763910F;
                    float km2_m2 = 0.0000010000F;
                    float milla2_m2 = 0.0000003861F;
                    float acre_m2 = 0.0002471054F;
                    float hect_m2 = 0.0001000000F;
                    float pulg2_m2 = 1550.00F;
                    float cm2_m2 = 10000.0000000000F;
                    float yarda2_m2 = 1.1959900460F;
                    float area_vTb1 = (float)Convert.ToDouble(tb1.Text);

                    calcularValores(area_vTb1, tb2, pie2_m2, tb3, km2_m2, tb4, milla2_m2, tb5, acre_m2, tb6, hect_m2, tb7, pulg2_m2, tb8, cm2_m2, tb9, yarda2_m2);
                    //float pie2m2 = area_vTb1 * pie2_m2;
                    //tb2.Text = "" + pie2m2;
                    //float km2m2 = area_vTb1 * km2_m2;
                    //tb3.Text = "" + km2m2;
                    //float milla2m2 = area_vTb1 * milla2_m2;
                    //tb4.Text = "" + milla2m2;
                    //float acreM2 = area_vTb1 * acre_m2;
                    //tb5.Text = "" + acreM2;
                    //float hectM2 = area_vTb1 * hect_m2;
                    //tb6.Text = "" + hectM2;
                    //float pulg2M2 = area_vTb1 * pulg2_m2;
                    //tb7.Text = "" + pulg2_m2;
                    //float cm2M2 = area_vTb1 * cm2_m2;
                    //tb8.Text = "" + cm2M2;
                    //float yarda2M2 = area_vTb1 * yarda2_m2;
                    //tb9.Text = "" + yarda2M2;
                }
                else if (tb2.Text != "")
                {
                    //valor en pi2
                    float m2_pie2 = 0.092903F;
                    float km2_pie2 = 0.0000000929F;
                    float milla2_pie2 = 0.0000000359F;
                    float acre_pie2 = 0.0000229568F;
                    float hect_pie2 = 0.0000092903F;
                    float pulg2_pie2 = 143.9999999955F;
                    float cm2_pie2 = 929.0303999749F;
                    float yarda2_pie2 = 0.1111111111F;
                    float area_vTb2 = (float)Convert.ToDouble(tb2.Text);
                    calcularValores(area_vTb2, tb1, m2_pie2, tb3, km2_pie2, tb4, milla2_pie2, tb5, acre_pie2, tb6, hect_pie2, tb7, pulg2_pie2, tb8, cm2_pie2, tb9, yarda2_pie2);

                    //float m2Pie2 = area_vTb2 * m2_pie2;
                    //tb1.Text = "" + m2Pie2;
                    //float km2Pie2 = area_vTb2 * km2_pie2;
                    //tb3.Text = "" + km2Pie2;
                    //float milla2Pie2 = area_vTb2 * milla2_pie2;
                    //tb4.Text = "" + milla2Pie2;
                    //float acrePie2 = area_vTb2 * acre_pie2;
                    //tb5.Text = "" + acrePie2;
                    //float hectPie2 = area_vTb2 * hect_pie2;
                    //tb6.Text = "" + hectPie2;
                    //float pulg2Pie2 = area_vTb2 * pulg2_pie2;
                    //tb7.Text = "" + pulg2Pie2;
                    //float cm2Pie2 = area_vTb2 * cm2_pie2;
                    //tb8.Text = "" + cm2Pie2;
                    //float yarda2Pie2 = area_vTb2 * yarda2_pie2;
                    //tb9.Text = "" + yarda2Pie2;

                }
                else if (tb3.Text != "")
                {
                    //valor en km2
                    float m2_km2 = 1000000.00F;
                    float pie2_km2 = 10763910.417F;
                    float milla2_km2 = 0.386F;
                    float acre_km2 = 247.105F;
                    float hect_km2 = 100.000F;
                    float pulg2_km2 = 1550003100.000F;
                    float cm2_km2 = 10000000000.000F;
                    float yarda2_km2 = 1195990.046F;
                    float area_vTb3 = (float)Convert.ToDouble(tb3.Text);
                    calcularValores(area_vTb3, tb1, m2_km2, tb2, pie2_km2, tb4, milla2_km2, tb5, acre_km2, tb6, hect_km2, tb7, pulg2_km2, tb8, cm2_km2, tb9, yarda2_km2);

                    //float m2km2 = area_vTb3 * m2_km2;
                    //tb1.Text = "" + m2km2;
                    //float pie2km2 = area_vTb3 * pie2_km2;
                    //tb2.Text = "" + pie2km2;
                    //float milla2km2 = area_vTb3 * milla2_km2;
                    //tb4.Text = "" + milla2km2;
                    //float acrekm2 = area_vTb3 * acre_km2;
                    //tb5.Text = "" + acrekm2;
                    //float hectkm2 = area_vTb3 * hect_km2;
                    //tb6.Text = "" + hectkm2;
                    //float pulg2km2 = area_vTb3 * pulg2_km2;
                    //tb7.Text = "" + pulg2km2;
                    //float cm2km2 = area_vTb3 * cm2_km2;
                    //tb8.Text = "" + cm2km2;
                    //float yarda2km2 = area_vTb3 * yarda2_km2;
                    //tb9.Text = "" + yarda2km2;

                }
                else if (tb4.Text != "")
                {
                    //valor en milla2
                    float m2_milla2 = 2589988.107F;
                    float pie2_milla2 = 27878399.968F;
                    float km2_milla2 = 2.590F;
                    float acre_milla2 = 640.000F;
                    float hect_milla2 = 258.999F;
                    float pulg2_milla2 = 4014489595.227F;
                    float cm2_milla2 = 25899881072.667F;
                    float yarda2_milla2 = 3097599.996F;
                    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(area_vTb4, tb1, m2_milla2, tb2, pie2_milla2, tb3, km2_milla2, tb5, acre_milla2, tb6, hect_milla2, tb7, pulg2_milla2, tb8, cm2_milla2, tb9, yarda2_milla2);

                    //float m2Milla2 = area_vTb4 * m2_milla2;
                    //tb1.Text = "" + m2Milla2;
                    //float pie2Milla2 = area_vTb4 * pie2_milla2;
                    //tb2.Text = "" + pie2Milla2;
                    //float km2Milla2 = area_vTb4 * km2_milla2;
                    //tb3.Text = "" + km2Milla2;
                    //float acreMilla2 = area_vTb4 * acre_milla2;
                    //tb5.Text = "" + acreMilla2;
                    //float hectMilla2 = area_vTb4 * hect_milla2;
                    //tb6.Text = "" + hectMilla2;
                    //float pulg2Milla2 = area_vTb4 * pulg2_milla2;
                    //tb7.Text = "" + pulg2Milla2;
                    //float cm2Milla2 = area_vTb4 * cm2_milla2;
                    //tb8.Text = "" + cm2Milla2;
                    //float yarda2Milla2 = area_vTb4 * yarda2_milla2;
                    //tb9.Text = "" + yarda2Milla2;

                }
                else if (tb5.Text != "")
                {
                    //valor en acre
                    float m2_acre = 4046.8564F;
                    float pie2_acre = 43560.0001F;
                    float km2_acre = 0.0040F;
                    float milla2_acre = 0.0016F;
                    float hect_acre = 0.4047F;
                    float pulg2_acre = 6272640.0118F;
                    float cm2_acre = 40468564.3005F;
                    float yarda2_acre = 4840.0000F;
                    float area_vTb5 = (float)Convert.ToDouble(tb5.Text);
                    calcularValores(area_vTb5, tb1, m2_acre, tb2, pie2_acre, tb3, km2_acre, tb4, milla2_acre, tb6, hect_acre, tb7, pulg2_acre, tb8, cm2_acre, tb9, yarda2_acre);

                    //float m2Acre = area_vTb5 * m2_acre;
                    //tb1.Text = "" + m2Acre;
                    //float pie2Acre = area_vTb5 * pie2_acre;
                    //tb2.Text = "" + pie2Acre;
                    //float km2Acre = area_vTb5 * km2_acre;
                    //tb3.Text = "" + km2Acre;
                    //float milla2Acre = area_vTb5 * milla2_acre;
                    //tb4.Text = "" + milla2Acre;
                    //float hectAcre = area_vTb5 * hect_acre;
                    //tb6.Text = "" + hectAcre;
                    //float pulg2Acre = area_vTb5 * pulg2_acre;
                    //tb7.Text = "" + pulg2Acre;
                    //float cm2Acre = area_vTb5 * cm2_acre;
                    //tb8.Text = "" + cm2Acre;
                    //float yarda2Acre = area_vTb5 * yarda2_acre;
                    //tb9.Text = "" + yarda2Acre;

                }
                else if (tb6.Text != "")
                {
                    //valor en hecta
                    float m2_hecta = 10000.0000F;
                    float pie2_hecta = 107639.1042F;
                    float km2_hecta = 0.0100F;
                    float milla2_hecta = 0.0039F;
                    float acre_hecta = 2.4711F;
                    float pulg2_hecta = 15500031.0000F;
                    float cm2_hecta = 100000000.0000F;
                    float yarda2_hecta = 11959.9005F;
                    float area_vTb6 = (float)Convert.ToDouble(tb6.Text);
                    calcularValores(area_vTb6, tb1, m2_hecta, tb2, pie2_hecta, tb3,km2_hecta, tb4, milla2_hecta, tb5, acre_hecta, tb7, pulg2_hecta, tb8, cm2_hecta, tb9, yarda2_hecta);

                    //float m2Hecta = area_vTb6 * m2_hecta;
                    //tb1.Text = "" + m2Hecta;
                    //float pie2Hecta = area_vTb6 * pie2_hecta;
                    //tb2.Text = "" + pie2Hecta;
                    //float km2Hecta = area_vTb6 * km2_hecta;
                    //tb3.Text = "" + km2Hecta;
                    //float milla2Hecta = area_vTb6 * milla2_hecta;
                    //tb4.Text = "" + milla2Hecta;
                    //float acreHecta = area_vTb6 * acre_hecta;
                    //tb5.Text = "" + acreHecta;
                    //float pulg2Hecta = area_vTb6 * pulg2_hecta;
                    //tb7.Text = "" + pulg2Hecta;
                    //float cm2Hecta = area_vTb6 * cm2_hecta;
                    //tb8.Text = "" + cm2Hecta;
                    //float yarda2Hecta = area_vTb6 * yarda2_hecta;
                    //tb9.Text = "" + yarda2Hecta;

                }
                else if (tb7.Text != "")
                {
                    //valor en pulg2
                    float m2_pulg2 = 0.0006F;
                    float pie2_pulg2 = 0.0069F;
                    float km2_pulg2 = 0.000000F;
                    float milla2_pulg2 = 0.000000F;
                    float acre_pulg2 = 0.000000F;
                    float hect_pulg2 = 0.000000F;
                    float cm2_pulg2 = 6.4516F;
                    float yarda2_pulg2 = 0.0008F;
                    float area_vTb7 = (float)Convert.ToDouble(tb7.Text);
                    calcularValores(area_vTb7, tb1, m2_pulg2, tb2, pie2_pulg2, tb3, km2_pulg2, tb4, milla2_pulg2, tb5, acre_pulg2, tb6, hect_pulg2, tb8, cm2_pulg2, tb9, yarda2_pulg2);

                    //float m2Pulg2 = area_vTb7 * m2_pulg2;
                    //tb1.Text = "" + m2Pulg2;
                    //float pie2Pulg2 = area_vTb7 * pie2_pulg2;
                    //tb2.Text = "" + pie2Pulg2;
                    //float km2Pulg2 = area_vTb7 * km2_pulg2;
                    //tb3.Text = "" + km2Pulg2;
                    //float milla2Pulg2 = area_vTb7 * milla2_pulg2;
                    //tb4.Text = "" + milla2Pulg2;
                    //float acrePulg2 = area_vTb7 * acre_pulg2;
                    //tb5.Text = "" + acrePulg2;
                    //float hectPulg2 = area_vTb7 * hect_pulg2;
                    //tb6.Text = "" + hectPulg2;
                    //float cm2Pulg2 = area_vTb7 * cm2_pulg2;
                    //tb8.Text = "" + cm2Pulg2;
                    //float yarda2Pulg2 = area_vTb7 * yarda2_pulg2;
                    //tb9.Text = "" + yarda2Pulg2;

                }
                else if (tb8.Text != "")
                {
                    //valor en cm2
                    float m2_cm2 = 0.0001F;
                    float pie2_cm2 = 0.0011F;
                    float km2_cm2 = 0.0000F;
                    float milla2_cm2 = 0.0000F;
                    float acre_cm2 = 0.0000F;
                    float hect_cm2 = 0.0000F;
                    float pulg2_cm2 = 0.1550F;
                    float yarda2_cm2 = 0.0001F;
                    float area_vTb8 = (float)Convert.ToDouble(tb8.Text);
                    calcularValores(area_vTb8, tb1, m2_cm2, tb2, pie2_cm2, tb3, km2_cm2, tb4, milla2_cm2, tb5, acre_cm2, tb6, hect_cm2, tb7, pulg2_cm2, tb9, yarda2_cm2);

                    //float m2Cm2 = area_vTb8 * m2_cm2;
                    //tb1.Text = "" + m2Cm2;
                    //float pie2Cm2 = area_vTb8 * pie2_cm2;
                    //tb2.Text = "" + pie2Cm2;
                    //float km2Cm2 = area_vTb8 * km2_cm2;
                    //tb3.Text = "" + km2Cm2;
                    //float milla2Cm2 = area_vTb8 * milla2_cm2;
                    //tb4.Text = "" + milla2Cm2;
                    //float acreCm2 = area_vTb8 * acre_cm2;
                    //tb5.Text = "" + acreCm2;
                    //float hectCm2 = area_vTb8 * hect_cm2;
                    //tb6.Text = "" + hectCm2;
                    //float pulg2Cm2 = area_vTb8 * pulg2_cm2;
                    //tb7.Text = "" + pulg2Cm2;
                    //float yarda2Cm2 = area_vTb8 * yarda2_cm2;
                    //tb9.Text = "" + yarda2Cm2;

                }
                else if (tb9.Text != "")
                {
                    //valor en yarda2
                    float m2_yarda2 = 0.8361F;
                    float pie2_yarda2 = 9.0000F;
                    float km2_yarda2 = 0.0000F;
                    float milla2_yarda2 = 0.0000F;
                    float acre_yarda2 = 0.0002F;
                    float hect_yarda2 = 0.0001F;
                    float pulg2_yarda2 = 1296.0000F;
                    float cm2_yarda2 = 8361.2736F;
                    float area_vTb9 = (float)Convert.ToDouble(tb9.Text);
                    calcularValores(area_vTb9, tb1, m2_yarda2, tb2, pie2_yarda2, tb3, km2_yarda2, tb4, milla2_yarda2, tb5, acre_yarda2, tb6, hect_yarda2, tb7, pulg2_yarda2, tb8, cm2_yarda2);

                    //float m2Yarda2 = area_vTb9 * m2_yarda2;
                    //tb1.Text = "" + m2Yarda2;
                    //float pie2Yarda2 = area_vTb9 * pie2_yarda2;
                    //tb2.Text = "" + pie2Yarda2;
                    //float km2Yarda2 = area_vTb9 * km2_yarda2;
                    //tb3.Text = "" + km2Yarda2;
                    //float milla2Yarda2 = area_vTb9 * milla2_yarda2;
                    //tb4.Text = "" + milla2Yarda2;
                    //float acreYarda2 = area_vTb9 * acre_yarda2;
                    //tb5.Text = "" + acreYarda2;
                    //float hectYarda2 = area_vTb9 * hect_yarda2;
                    //tb6.Text = "" + hectYarda2;
                    //float pulg2Yarda2 = area_vTb9 * pulg2_yarda2;
                    //tb7.Text = "" + pulg2Yarda2;
                    //float cm2Yarda2 = area_vTb9 * cm2_yarda2;
                    //tb8.Text = "" + cm2Yarda2;
                }
            }//comboBox item 1
            else if (cbUnidades.SelectedIndex == 2)
            {
                //volumen
                if (tb1.Text != "")
                {
                    //valor en m3
                    float gal_m3 = 264.1721F;
                    float l_m3 = 1000.0000F;
                    float barril_m3 = 6.2898F;
                    float pie3_m3 = 35.3147F;
                    float cm3_m3 = 1000000.0000F;
                    float pulg3_m3 = 61023.7441F;
                    float yarda3_m3 = 1.3080F;
                    float acrePie_m3 = 0.0008F;
                    float volumen_vTb1 = (float)Convert.ToDouble(tb1.Text);
                    calcularValores(volumen_vTb1, tb2,gal_m3 , tb3,l_m3, tb4,barril_m3 , tb5, pie3_m3, tb6,cm3_m3 , tb7,pulg3_m3, tb8,yarda3_m3, tb9,acrePie_m3 );

                    //float galM3 = volumen_vTb1 * gal_m3;
                    //tb2.Text = "" + galM3;
                    //float lM3 = volumen_vTb1 * l_m3;
                    //tb3.Text = "" + lM3;
                    //float barrilM3 = volumen_vTb1 * barril_m3;
                    //tb4.Text = "" + barrilM3;
                    //float pie3M3 = volumen_vTb1 * pie3_m3;
                    //tb5.Text = "" + pie3M3;
                    //float cm3M3 = volumen_vTb1 * cm3_m3;
                    //tb6.Text = "" + cm3M3;
                    //float pulg3M3 = volumen_vTb1 * pulg3_m3;
                    //tb7.Text = "" + pulg3M3;
                    //float yarda3M3 = volumen_vTb1 * yarda3_m3;
                    //tb8.Text = "" + yarda3M3;
                    //float acrepieM3 = volumen_vTb1 * acrePie_m3;
                    //tb9.Text = "" + acrepieM3;

                }
                else if (tb2.Text != "")
                {
                    //valor en gal
                    float m3_gal = 0.0038F;
                    float l_gal = 3.7854F;
                    float barril_gal = 0.0238F;
                    float pie3_gal = 0.1337F;
                    float cm3_gal = 3785.4118F;
                    float pulg3_gal = 231.0000F;
                    float yarda3_gal = 0.0050F;
                    float acrePie_gal = 0.0000F;
                    float volumen_vTb2 = (float)Convert.ToDouble(tb2.Text);
                    calcularValores(volumen_vTb2, tb1, m3_gal, tb3, l_gal, tb4,barril_gal, tb5,pie3_gal, tb6, cm3_gal, tb7,pulg3_gal, tb8,yarda3_gal, tb9,acrePie_gal);


                    //float m3Gal = volumen_vTb2 * m3_gal;
                    //tb1.Text = "" + m3Gal;
                    //float lGal = volumen_vTb2 * l_gal;
                    //tb3.Text = "" + lGal;
                    //float barrilGal = volumen_vTb2 * barril_gal;
                    //tb4.Text = "" + barrilGal;
                    //float pie3Gal = volumen_vTb2 * pie3_gal;
                    //tb5.Text = "" + pie3Gal;
                    //float cm3Gal = volumen_vTb2 * cm3_gal;
                    //tb6.Text = "" + cm3Gal;
                    //float pulg3Gal = volumen_vTb2 * pulg3_gal;
                    //tb7.Text = "" + pulg3Gal;
                    //float yarda3Gal = volumen_vTb2 * yarda3_gal;
                    //tb8.Text = "" + yarda3Gal;
                    //float acrepieGal = volumen_vTb2 * acrePie_gal;
                    //tb9.Text = "" + acrepieGal;

                }
                else if (tb3.Text != "")
                {
                    //valor en L
                    float m3_l = 0.0010F;
                    float gal_l = 0.2642F;
                    float barril_l = 0.0063F;
                    float pie3_l = 0.0353F;
                    float cm3_l = 1000.0000F;
                    float pulg3_l = 61.0237F;
                    float yarda3_l = 0.0013F;
                    float acrePie_l = 0.0000F;
                    float volumen_vTb3 = (float)Convert.ToDouble(tb3.Text);
                    calcularValores(volumen_vTb3, tb1,m3_l, tb2,gal_l, tb4, barril_l, tb5,pie3_l, tb6,cm3_l, tb7, pulg3_l, tb8,yarda3_l, tb9, acrePie_l);


                    //float m3L = volumen_vTb3 * m3_l;
                    //tb1.Text = "" + m3L;
                    //float galL = volumen_vTb3 * gal_l;
                    //tb2.Text = "" + galL;
                    //float barrilL = volumen_vTb3 * barril_l;
                    //tb4.Text = "" + barrilL;
                    //float pie3L = volumen_vTb3 * pie3_l;
                    //tb5.Text = "" + pie3L;
                    //float cm3L = volumen_vTb3 * cm3_l;
                    //tb6.Text = "" + cm3L;
                    //float pulg3L = volumen_vTb3 * pulg3_l;
                    //tb7.Text = "" + pulg3L;
                    //float yarda3L = volumen_vTb3 * yarda3_l;
                    //tb8.Text = "" + yarda3L;
                    //float acrepieL = volumen_vTb3 * acrePie_l;
                    //tb9.Text = "" + acrepieL;
                }
                else if (tb4.Text != "")
                {
                    //valor en barril
                    float m3_barril = 0.1590F;
                    float gal_barril = 42.0000F;
                    float l_barril = 158.9873F;
                    float pie3_barril = 5.6146F;
                    float cm3_barril = 158987.2949F;
                    float pulg3_barril = 9702.0000F;
                    float yarda3_barril = 0.2079F;
                    float acrePie_barril = 0.0001F;
                    float volumen_vTb4 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(volumen_vTb4, tb1, m3_barril, tb2,gal_barril, tb3, l_barril, tb5, pie3_barril, tb6, cm3_barril, tb7, pulg3_barril,tb8,yarda3_barril, tb9, acrePie_barril);

                    //float m3Barril = volumen_vTb4 * m3_barril;
                    //tb1.Text = "" + m3Barril;
                    //float galBarril = volumen_vTb4 * gal_barril;
                    //tb2.Text = "" + galBarril;
                    //float lBarril = volumen_vTb4 * l_barril;
                    //tb3.Text = "" + lBarril;
                    //float pie3Barril = volumen_vTb4 * pie3_barril;
                    //tb5.Text = "" + pie3Barril;
                    //float cm3Barril = volumen_vTb4 * cm3_barril;
                    //tb6.Text = "" + cm3Barril;
                    //float pulg3Barril = volumen_vTb4 * pulg3_barril;
                    //tb7.Text = "" + pulg3Barril;
                    //float yarda3Barril = volumen_vTb4 * yarda3_barril;
                    //tb8.Text = "" + yarda3Barril;
                    //float acrepieBarril = volumen_vTb4 * acrePie_barril;
                    //tb9.Text = "" + acrepieBarril;
                }
                else if (tb5.Text != "")
                {
                    //valor en pie3
                    float m3_pie3 = 0.0283F;
                    float gal_pie3 = 7.4805F;
                    float l_pie3 = 28.3168F;
                    float barril_pie3 = 0.1781F;
                    float cm3_pie3 = 28316.8466F;
                    float pulg3_pie3 = 1728.0000F;
                    float yarda3_pie3 = 0.0370F;
                    float acrePie_pie3 = 0.0000F;
                    float volumen_vTb5 = (float)Convert.ToDouble(tb5.Text);
                    calcularValores(volumen_vTb5, tb1, m3_pie3, tb2, gal_pie3, tb3, l_pie3, tb4, barril_pie3, tb6, cm3_pie3, tb7, pulg3_pie3, tb8, yarda3_pie3, tb9, acrePie_pie3);

                    //float m3Pie3 = volumen_vTb5 * m3_pie3;
                    //tb1.Text = "" + m3Pie3;
                    //float galPie3 = volumen_vTb5 * gal_pie3;
                    //tb2.Text = "" + galPie3;
                    //float lPie3 = volumen_vTb5 * l_pie3;
                    //tb3.Text = "" + lPie3;
                    //float barrilPie3 = volumen_vTb5 * barril_pie3;
                    //tb4.Text = "" + barrilPie3;
                    //float cm3Pie3 = volumen_vTb5 * cm3_pie3;
                    //tb6.Text = "" + cm3Pie3;
                    //float pulg3Pie3 = volumen_vTb5 * pulg3_pie3;
                    //tb7.Text = "" + pulg3Pie3;
                    //float yarda3Pie3 = volumen_vTb5 * yarda3_pie3;
                    //tb8.Text = "" + yarda3Pie3;
                    //float acrepiePie3 = volumen_vTb5 * acrePie_pie3;
                    //tb9.Text = "" + acrepiePie3;

                }
                else if (tb6.Text != "")
                {
                    //valor en cm3
                    float m3_cm3 = 0.000001F;
                    float gal_cm3 = 0.000264F;
                    float l_cm3 = 0.001000F;
                    float barril_cm3 = 0.000006F;
                    float pie3_cm3 = 0.000035F;
                    float pulg3_cm3 = 0.061024F;
                    float yarda3_cm3 = 0.000001F;
                    float acrePie_cm3 = 0.000000F;
                    float volumen_vTb6 = (float)Convert.ToDouble(tb6.Text);
                    calcularValores(volumen_vTb6, tb1, m3_cm3, tb2, gal_cm3, tb3, l_cm3, tb4, barril_cm3, tb5, pie3_cm3, tb7, pulg3_cm3, tb8, yarda3_cm3, tb9, acrePie_cm3);

                    //float m3Cm3 = volumen_vTb6 * m3_cm3;
                    //tb1.Text = "" + m3Cm3;
                    //float galCm3 = volumen_vTb6 * gal_cm3;
                    //tb2.Text = "" + galCm3;
                    //float lCm3 = volumen_vTb6 * l_cm3;
                    //tb3.Text = "" + lCm3;
                    //float barrilCm3 = volumen_vTb6 * barril_cm3;
                    //tb4.Text = "" + barrilCm3;
                    //float pie3Cm3 = volumen_vTb6 * pie3_cm3;
                    //tb5.Text = "" + pie3Cm3;
                    //float pulg3Cm3 = volumen_vTb6 * pulg3_cm3;
                    //tb7.Text = "" + pulg3Cm3;
                    //float yarda3Cm3 = volumen_vTb6 * yarda3_cm3;
                    //tb8.Text = "" + yarda3Cm3;
                    //float acrepieCm3 = volumen_vTb6 * acrePie_cm3;
                    //tb9.Text = "" + acrepieCm3;
                }
                else if (tb7.Text != "")
                {
                    //valor en pulg3
                    float m3_pulg3 = 0.000016F;
                    float gal_pulg3 = 0.004329F;
                    float l_pulg3 = 0.016387F;
                    float barril_pulg3 = 0.000103F;
                    float pie3_pulg3 = 0.000579F;
                    float cm3_pulg3 = 16.387064F;
                    float yarda3_pulg3 = 0.000021F;
                    float acrePie_pulg3 = 0.000000F;
                    float volumen_vTb7 = (float)Convert.ToDouble(tb7.Text);
                    calcularValores(volumen_vTb7, tb1, m3_pulg3, tb2,gal_pulg3, tb3, l_pulg3, tb4, barril_pulg3, tb5, pie3_pulg3, tb6, cm3_pulg3, tb8, yarda3_pulg3, tb9, acrePie_pulg3);

                    //float m3Pulg3 = volumen_vTb7 * m3_pulg3;
                    //tb1.Text = "" + m3Pulg3;
                    //float galPulg3 = volumen_vTb7 * gal_pulg3;
                    //tb2.Text = "" + galPulg3;
                    //float lPulg3 = volumen_vTb7 * l_pulg3;
                    //tb3.Text = "" + lPulg3;
                    //float barrilPulg3 = volumen_vTb7 * barril_pulg3;
                    //tb4.Text = "" + barrilPulg3;
                    //float pie3Pulg3 = volumen_vTb7 * pie3_pulg3;
                    //tb5.Text = "" + pie3Pulg3;
                    //float cm3Pulg3 = volumen_vTb7 * cm3_pulg3;
                    //tb6.Text = "" + cm3Pulg3;
                    //float yarda3Pulg3 = volumen_vTb7 * yarda3_pulg3;
                    //tb8.Text = "" + yarda3Pulg3;
                    //float acrepiePulg3 = volumen_vTb7 * acrePie_pulg3;
                    //tb9.Text = "" + acrepiePulg3;
                }
                else if (tb8.Text != "")
                {
                    //valor en yarda3
                    float m3_yarda3 = 0.764555F;
                    float gal_yarda3 = 201.974026F;
                    float l_yarda3 = 764.554858F;
                    float barril_yarda3 = 4.808905F;
                    float pie3_yarda3 = 27.000000F;
                    float cm3_yarda3 = 764554.858168F;
                    float pulg3_yarda3 = 46656.000011F;
                    float acrePie_yarda3 = 0.000620F;
                    float volumen_vTb8 = (float)Convert.ToDouble(tb8.Text);
                    calcularValores(volumen_vTb8, tb1, m3_yarda3, tb2, gal_yarda3, tb3, l_yarda3, tb4, barril_yarda3, tb5, pie3_yarda3, tb6, cm3_yarda3, tb7, pulg3_yarda3, tb9, acrePie_yarda3);

                    //float m3Yarda3 = volumen_vTb8 * m3_yarda3;
                    //tb1.Text = "" + m3Yarda3;
                    //float galYarda3 = volumen_vTb8 * gal_yarda3;
                    //tb2.Text = "" + galYarda3;
                    //float lYarda3 = volumen_vTb8 * l_yarda3;
                    //tb3.Text = "" + lYarda3;
                    //float barrilYarda3 = volumen_vTb8 * barril_yarda3;
                    //tb4.Text = "" + barrilYarda3;
                    //float pie3Yarda3 = volumen_vTb8 * pie3_yarda3;
                    //tb5.Text = "" + pie3Yarda3;
                    //float cm3Yarda3 = volumen_vTb8 * cm3_yarda3;
                    //tb6.Text = "" + cm3Yarda3;
                    //float pulg3Yarda3 = volumen_vTb8 * pulg3_yarda3;
                    //tb7.Text = "" + pulg3Yarda3;
                    //float acrepieYarda3 = volumen_vTb8 * acrePie_yarda3;
                    //tb9.Text = "" + acrepieYarda3;
                }
                else if (tb9.Text != "")
                {
                    //valor en acrepie
                    float m3_acrepie = 1233.481843F;
                    float gal_acrepie = 325851.430146F;
                    float l_acrepie = 1233481.843314F;
                    float barril_acrepie = 7758.367383F;
                    float pie3_acrepie = 43560.000202F;
                    float cm3_acrepie = 1233481843.313787F;
                    float pulg3_acrepie = 75271680.352209F;
                    float yarda3_acrepie = 1613.333340F;
                    float volumen_vTb9 = (float)Convert.ToDouble(tb9.Text);
                    calcularValores(volumen_vTb9, tb1, m3_acrepie, tb2, gal_acrepie, tb3, l_acrepie, tb4, barril_acrepie, tb5, pie3_acrepie, tb6, cm3_acrepie, tb7, pulg3_acrepie,tb8, yarda3_acrepie);

                    //float m3Acrepie = volumen_vTb9 * m3_acrepie;
                    //tb1.Text = "" + m3Acrepie;
                    //float galAcrepie = volumen_vTb9 * gal_acrepie;
                    //tb2.Text = "" + galAcrepie;
                    //float lAcrepie = volumen_vTb9 * l_acrepie;
                    //tb3.Text = "" + lAcrepie;
                    //float barrilAcrepie = volumen_vTb9 * barril_acrepie;
                    //tb4.Text = "" + barrilAcrepie;
                    //float pie3Acrepie = volumen_vTb9 * pie3_acrepie;
                    //tb5.Text = "" + pie3Acrepie;
                    //float cm3Acrepie = volumen_vTb9 * cm3_acrepie;
                    //tb6.Text = "" + cm3Acrepie;
                    //float pulg3Acrepie = volumen_vTb9 * pulg3_acrepie;
                    //tb7.Text = "" + pulg3Acrepie;
                    //float yarda3Acrepie = volumen_vTb9 * yarda3_acrepie;
                    //tb8.Text = "" + yarda3Acrepie;

                }
            }//comboBox item 2
            else if (cbUnidades.SelectedIndex == 3)
            {
                //temperatura
                if (tb1.Text != "")
                {
                    //valor en centigrados
                    float f_c = 33.8F;
                    float k_c = 274.1F;
                    float r_c = 493.5F;

                    float temp_vTb1 = (float)Convert.ToDouble(tb1.Text);

                    calcularValores(temp_vTb1, tb2, f_c, tb3, k_c, tb4, r_c , tb5 ,0.0F,tb6, 0.0F,tb7, 0.0F,tb8,0.0F,tb9,0.0F);

                    //float fC = temp_vTb1 * f_c;
                    //tb2.Text = "" + fC;
                    //float kC = temp_vTb1 * k_c;
                    //tb3.Text = "" + kC;
                    //float rC = temp_vTb1 * r_c;
                    //tb4.Text = "" + rC;

                }
                else if (tb2.Text != "")
                {
                    //valor en Fahrenheit
                    float c_f = -17.2F;
                    float k_f = 255.9F;
                    float r_f = 460.7F;

                    float temp_vTb2 = (float)Convert.ToDouble(tb2.Text);

                    calcularValores(temp_vTb2, tb1, c_f, tb3, k_f,tb4, r_f, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                    //float cF = temp_vTb2 * c_f;
                    //tb2.Text = "" + cF;
                    //float kF = temp_vTb2 * k_f;
                    //tb3.Text = "" + kF;
                    //float rF = temp_vTb2 * r_f;
                    //tb4.Text = "" + rF;

                }
                else if (tb3.Text != "")
                {
                    //valor en kelvin
                    float c_k = -272.1F;
                    float f_k = -457.9F;
                    float r_k = 1.8F;
                    float temp_vTb3 = (float)Convert.ToDouble(tb3.Text);
                    calcularValores(temp_vTb3, tb1, c_k, tb2, f_k, tb4, r_k , tb5 ,0.0F,tb6, 0.0F,tb7, 0.0F,tb8,0.0F,tb9,0.0F);

                    //float cK = temp_vTb3 * c_k;
                    //tb1.Text = "" + cK;
                    //float fK = temp_vTb3 * f_k;
                    //tb2.Text = "" + fK;
                    //float rK = temp_vTb3 * r_k;
                    //tb4.Text = "" + rK;

                }
                else if (tb4.Text != "")
                {
                    //valor en rankine
                    float c_r = -273.1F;
                    float f_r = -458.7F;
                    float k_r = 0.6F;

                    float temp_vTb4 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(temp_vTb4, tb1, c_r, tb2, f_r, tb3, k_r, tb5, 0.0F, tb6, 0.0F, tb7, 0.0F, tb8, 0.0F, tb9, 0.0F);
                //    float cR = temp_vTb4 * c_r;
                //    tb2.Text = "" + cR;
                //    float fR = temp_vTb4 * f_r;
                //    tb3.Text = "" + fR;
                //    float kR = temp_vTb4 * k_r;
                //    tb4.Text = "" + kR;
                }

            }//comboBox item 3
            else if (cbUnidades.SelectedIndex == 4)
            {
                //presion
                if (tb1.Text != "")
                {
                    //valor en bar
                    float psi_bar = 14.50F;
                    float kpa_bar = 100.0F;
                    float atm_bar = 0.99F;
                    float kgcm2_bar = 1.02F;
                    float mmhg_bar = 750.06F;
                    float pieagua_bar = 33.49F;
                    float cmagua_bar = 1020.72F;
                    float pa_bar = 100000.00F;
                    float presion_vTb1 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(presion_vTb1, tb2, psi_bar, tb3, kpa_bar, tb4, atm_bar, tb5, kgcm2_bar, tb6, mmhg_bar, tb7, pieagua_bar, tb8, cmagua_bar, tb9, pa_bar);

                    //    float psiBar = presion_vTb1 * psi_bar;
                    //    tb2.Text = "" + psiBar;
                    //    float kpaBar = presion_vTb1 * kpa_bar;
                    //    tb3.Text = "" + kpaBar;
                    //    float atmBar = presion_vTb1 * atm_bar;
                    //    tb4.Text = "" + atmBar;
                    //    float kgcm2Bar = presion_vTb1 * kgcm2_bar;
                    //    tb5.Text = "" + kgcm2Bar;
                    //    float mmhgBar = presion_vTb1 * mmhg_bar;
                    //    tb6.Text = "" + mmhgBar;
                    //    float pieaguaBar = presion_vTb1 * pieagua_bar;
                    //    tb7.Text = "" + pieaguaBar;
                    //    float cmaguaBar = presion_vTb1 * cmagua_bar;
                    //    tb8.Text = "" + cmaguaBar;
                    //    float paBar = presion_vTb1 * pa_bar;
                    //    tb9.Text = "" + paBar;
                }
                else if (tb2.Text != "")
                {
                    //valor en psi
                    float bar_psi = 0.07F;
                    float kpa_psi = 6.89F;
                    float atm_psi = 0.07F;
                    float kgcm2_psi = 0.07F;
                    float mmhg_psi = 51.72F;
                    float pieagua_psi = 2.31F;
                    float cmagua_psi= 70.38F;
                    float pa_psi = 6894.78F;
                    float presion_vTb2 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(presion_vTb2, tb1, bar_psi, tb3, kpa_psi, tb4, atm_psi, tb5, kgcm2_psi, tb6,mmhg_psi, tb7, pieagua_psi, tb8, cmagua_psi, tb9, pa_psi );

                    //float  = presion_vTb1 * ;
                    //tb1.Text = "" + ;
                    //float  = presion_vTb1 * ;
                    //tb2.Text = "" + ;
                    //float  = presion_vTb1 *;
                    //tb4.Text = "" + ;
                    //float  = presion_vTb1 * ;
                    //tb5.Text = "" + ;
                    //float = presion_vTb1 *;
                    //tb6.Text = "" + ;
                    //float  = presion_vTb1 *;
                    //tb7.Text = "" +;
                    //float  = presion_vTb1 *;
                    //tb8.Text = "" + ;
                    //float  = presion_vTb1 * ;
                    //tb9.Text = "" + ;
                }
                else if (tb3.Text != "")
                {
                    //valor en kPa
                    float bar_kpa = 0.01F;
                    float psi_kpa = 0.15F;
                    float atm_kpa = 0.01F;
                    float kgcm2_kpa = 0.01F;
                    float mmhg_kpa = 7.50F;
                    float pieagua_kpa = 0.33F;
                    float cmagua_kpa= 10.21F;
                    float pa_kpa = 1000.00F;
                    float presion_vTb3= (float)Convert.ToDouble(tb4.Text);
                    calcularValores(presion_vTb3, tb1, bar_kpa, tb2, psi_kpa, tb4, atm_kpa, tb5, kgcm2_kpa, tb6, mmhg_kpa, tb7, pieagua_kpa, tb8, cmagua_kpa, tb9, pa_kpa);
                    }
                    else if (tb4.Text != "")
                    {
                    //valor en atm
                    float  bar_atm = 1.01F;
                    float  psi_atm = 14.70F;
                    float  kpa_atm= 101.33F;
                    float  kgcm2_atm = 1.03F;
                    float  mmhg_atm = 760.00F;
                    float  pieagua_atm = 33.93F;
                    float  cmagua_atm= 1034.25F;
                    float  pa_atm = 101325.00F;
                    float presion_vTb4 = (float)Convert.ToDouble(tb4.Text);
                    calcularValores(presion_vTb4, tb1, bar_atm,tb2,psi_atm,tb3,kpa_atm,tb5, kgcm2_atm, tb6, mmhg_atm,tb7, pieagua_atm, tb8, cmagua_atm, tb9, pa_atm);
                   }
                    else if (tb5.Text != "")
                    {//valor en kg/cm2
                        float presion_vTb5 = (float)Convert.ToDouble(tb4.Text);
                        calcularValores(presion_vTb5, tb1, 0.98F, tb2, 14.22F, tb3, 98.07F, tb4, 0.97F, tb6, 735.56F, tb7, 32.84F , tb8, 1000.99F, tb9, 98066.50F);
                    }
                    else if (tb6.Text != "")
                    {//valor en mmhg
                       float presion_vTb6 = (float)Convert.ToDouble(tb6.Text);
                     //  calcularValores(presion_vTb6, tb1, 0.001F, );
                    }
                    //else if (tb1.Text != "")
                    //{
                    //    //valor en bar
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float = F;
                    //    float  = F;
                    //    float presion_vTb1 = (float)Convert.ToDouble(tb4.Text);
          
                    //}
                    //else if (tb1.Text != "")
                    //{
                    //    //valor en bar
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float = F;
                    //    float  = F;
                    //    float presion_vTb1 = (float)Convert.ToDouble(tb4.Text);
 
                    //}
                    //else if (tb1.Text != "")
                    //{
                    //    //valor en bar
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float  = F;
                    //    float = F;
                    //    float  = F;
                    //    float presion_vTb1 = (float)Convert.ToDouble(tb4.Text);
                //}

                }//comboBox item 4
            else if (cbUnidades.SelectedIndex == 5)
            {
                //masa
                //if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);


                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
       

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);


                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
        

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
           

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
          

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
     

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
             

                //}
                //else if (tb.Text != "")
                //{
                //    //valor en yarda2
                //    float m2_ = F;
                //    float pie2_ = F;
                //    float milla2_ = F;
                //    float acre_ = F;
                //    float hect_ = F;
                //    float pulg2_ = F;
                //    float cm2_ = F;
                //    float yarda2_ = F;
                //    float area_vTb4 = (float)Convert.ToDouble(tb4.Text);
               

                //}

            }//comboBox item 5


        }

        private void calcularValores(float vTb1, TextBox tb2, float valor1, TextBox tb3, float valor2, TextBox tb4, float valor3, TextBox tb5, float valor4, TextBox tb6, float valor5, TextBox tb7, float valor6, TextBox tb8, float valor7, TextBox tb9, float valor8)
        {
            tb2.Text = "" + vTb1 * valor1;
            tb3.Text = "" + vTb1 * valor2; 
            tb4.Text = "" + vTb1 * valor3; 
            tb5.Text = "" + vTb1 * valor4; 
            tb6.Text = "" + vTb1 * valor5; 
            tb7.Text = "" + vTb1 * valor6; 
            tb8.Text = "" + vTb1 * valor7; 
            tb9.Text = "" + vTb1 * valor8; 
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
                    lMsj.Text = "Solo se admiten números";
                    // MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                lMsj.Text = "";
            }//tb1
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb2.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb2
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb3.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    // MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb3
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb4.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    // MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb4
        }

        private void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb5.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    // MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb5
        }

        private void tb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb6.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb6
        }

        private void tb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb7.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb17
        }

        private void tb8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb8.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    // MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";

            }//tb8
        }

        private void tb9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (tb9.Text != "")
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lMsj.Text = "Solo se admiten números";

                }
                lMsj.Text = "";
            }//tb9
        }


    }
}

