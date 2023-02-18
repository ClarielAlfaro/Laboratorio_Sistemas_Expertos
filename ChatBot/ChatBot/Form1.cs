using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desactivar();
            lblbot.Text = "Hola, como puedo ayudarte?";
            btnnew.Visible = false;
        }

        void desactivar()
        {
            lblbot.Visible = true;  
            txtres.Visible = false;
            txtbot2.Visible = false;
        }

        void activar()
        {
            txtres.Visible = true;
            lblbot.Visible = false;
            txtbot2.Visible = true;
        }

        void proceso()
        {

        }

       

        private void btnok_Click(object sender, EventArgs e)
        {
            using (chatbot3Entities bd = new chatbot3Entities())
            {

                pregunta pre = new pregunta();
                respuesta res = new respuesta();

                activar();
                string pregunta = txtuser.Text;

                txtres.Text = pregunta;


                if (pregunta.Contains("hora"))
                {
                    DateTime hora = DateTime.Now;
                    txtbot2.Text = hora.ToString("h:mm:ss tt");
                    txtuser.Text = "";

                }
                else if (pregunta.Contains("dia"))
                {
                    DateTime dia = DateTime.Now;
                    txtbot2.Text = dia.ToString();
                    txtuser.Text = "";

                }
                else if(bd.pregunta.Where(idBuscar => idBuscar.descripcion.Contains(pregunta)).FirstOrDefault() != null)
                {


                    pre = bd.pregunta.Where(idBuscar => idBuscar.descripcion.Contains(pregunta)).First();
                    int idpregunta = pre.idpregunta;



                    res = bd.respuesta.Where(idBuscar => idBuscar.idpregunta == idpregunta).First();
                    string repuesta = res.descripcion.ToString();

                    txtbot2.Text = repuesta;
                    txtuser.Text = "";

                }
                else
                {

                    txtbot2.Text = "No comprendo tu solicitud, cual seria una respuesta idonea para tu solicitud?";
                    btnnew.Visible = true;
                    btnok.Visible = false;
                    txtuser.Text = "";
                    
                }  

                             

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {

            using (chatbot3Entities bd = new chatbot3Entities())
            {

                pregunta pre = new pregunta();
                respuesta res = new respuesta();

                if (txtuser.Text != "")
                {

                    string Res = txtuser.Text;
                    string Pre = txtres.Text;

                    pre.descripcion = Pre;
                    bd.pregunta.Add(pre);
                    bd.SaveChanges();

                    pre = bd.pregunta.Where(idBuscar => idBuscar.descripcion.Contains(Pre)).First();
                    int idpregunta = pre.idpregunta;


                    res.descripcion = Res;
                    res.idpregunta = idpregunta;
                    bd.respuesta.Add(res);
                    bd.SaveChanges();

                    txtuser.Text = "";
                    txtbot2.Text = "Gracias por ayudarme ha aprender";
                    txtres.Text = "";
                    btnnew.Visible = false;
                    btnok.Visible = true;



                }

            }              



        }
    } 
}
