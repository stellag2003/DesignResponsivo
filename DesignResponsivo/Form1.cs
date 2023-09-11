namespace DesignResponsivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void renderizaInterface()
        {
            int menuEsquerdo_largura = 300;
            int menuEsquerdo_altura = ClientSize.Height;


           WindowState = FormWindowState.Maximized;

            // WIDTH -> largura
            // HEIGH -> altura

            // Jogar o painel no meio da tela
            painel.Location = new Point(ClientSize.Width/2 - painel.Size.Width/2 + 150, ClientSize.Height/2 - painel.Size.Height/2);
            

            // Configuração do menu esquerdo
            menuEsquerdo.Location = new Point(0,0);
            menuEsquerdo.Size = new Size(200,ClientSize.Height);

            menuCima.Location= new Point(0,0);
            menuCima.Size = new Size(ClientSize.Width,200);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();


        }
    }
}