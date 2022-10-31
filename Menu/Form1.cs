namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void mi_Theme_Light_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if (it.Checked == true)
            {
                this.BackColor = Color.White;

            }
            mi_Theme_Dark.Checked = false;
        }
        private void mi_Theme_Dark_Click_1(object sender, EventArgs e)
        {
            if (mi_Theme_Dark.Checked == true)
            {
                this.BackColor = Color.DarkGray;
            }
            mi_Theme_Light.Checked = false;
        }
       
    }
    
}