using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LinqExcersiceWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        

            var result = Mockdata.GetAllMovies();

            dataGridView1.DataSource = result.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1. Visa alla filmer som släpptes någon gång under 90-talet.
            var result = Mockdata.GetAllMovies().Where(f => f.ReleaseYear >= 1990 && f.ReleaseYear <= 1999);
            dataGridView1.DataSource = result.ToArray();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Visa alla filmer vars Actor-lista innehåller tre skådespelare  (tips: för detta kan du behöva använda metoden Count)
            var result = Mockdata.GetAllMovies().Where(f => f.Actors.Count() == 3);
            dataGridView1.DataSource = result.ToArray();
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            /// Visa alla filmer som där någon av skådespelarna i filmen var äldre än 40 år när filmen gjordes
            /// 
            var result = Mockdata.GetAllMovies().Where(a => a.Actors.Any(c => c.Birthyear + 40 < a.ReleaseYear));
            dataGridView1.DataSource = result.ToArray();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //Visa alla skådespelare som är äldre än 50 år. Sortera skådespelarna på namn.
            var result = Mockdata.GetAllActors().Where(a => DateTime.Now.Year - a.Birthyear > 50).OrderBy(a => a.Name);
            dataGridView1.DataSource = result.ToArray();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Visa alla skådespelare som har bokstaven "g" eller ”G” i sitt namn. Det skall inte spela
            //någon roll om det är med stor eller liten bokstav alla skall visas.
            var result = Mockdata.GetAllActors().Where(a => a.Name.ToLower().Contains("g"));

            dataGridView1.DataSource = result.ToArray();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Visa för alla skådespelare bara deras namn och ålder.
            var result = Mockdata.GetAllActors().Select(a => new { a.Name, Age = (DateTime.Now.Year - a.Birthyear) });
            dataGridView1.DataSource = result.ToArray();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Visa en lista innehållande filmtitel, regissör och antal skådespelare för alla filmer.
            var result = Mockdata.GetAllMovies().Select(a => new { a.Title, a.Director, ActorsNr = a.Actors.Count() });
            dataGridView1.DataSource = result.ToArray();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Visa för alla filmer filmens titel, samt genomsnittliga åldern för skådespelarna i filmen
            var result = Mockdata.GetAllMovies().Select(a => new { a.Title, AvgActOld = a.Actors.Select(b => DateTime.Now.Year - b.Birthyear).Average() });
            dataGridView1.DataSource = result.ToArray();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ta fram alla filmer som gjordes under 2000-talet och där regissören heter Martin
            //Scorsese.Visa bara Titel, release år och regissör.
            var result = Mockdata.GetAllMovies().Where(a => a.ReleaseYear > 2000 && a.Director.Contains("Martin Scorsese")).Select(a => new {a.Title, a.ReleaseYear, a.Director});
            dataGridView1.DataSource = result.ToArray();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Visa alla skådespelare som är med i mer än en film. Visa också hur många filmer de är med i.
            var result = Mockdata.GetAllActors().Select(a => new { a.Name, Count = Mockdata.GetAllMovies().Count(m => m.Actors.Any(ma => ma.Id == a.Id)) }).Where(x => x.Count > 1);
            dataGridView1.DataSource = result.ToArray();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // visa alla filmer vars årtal är senare än det genomsnittliga årtalet för alla filmer.Sortera resultatet på årtalet i stigande ordning(ascending).
            var result = Mockdata.GetAllMovies().Where(a => a.ReleaseYear > Mockdata.GetAllMovies().Average(b => b.ReleaseYear)).Select(a => new {a.Title, a.ReleaseYear, a.Director}).OrderBy(a => a.ReleaseYear); 
            dataGridView1.DataSource = result.ToArray();
        }
    }
}
