using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudbina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sasaText = new string[6];
            sasaText[0]= "VOLIM AHILEJE Ahilej je vrlo privlačan, ali tajanstven muškarac. " +
                "On zna kako da sakrije svoje fizičke i druge mane, zato uvek deluje " +
                "sigurno u sebe.Obožava da mu se posvećuje pažnja. Ume da bude brižan i " +
                "poseban. Na prvi pogled izgleda neustrašivo, kao čovek koji nema razloga " +
                "za brigu i koji ima sve.Međutim, ispod te površine krije se prava enigma.Zato " +
                "se naoružajte strpljenjem jer ga nećete tako lako prokljuviti.";
            sasaText[1]= "VOLIM ADONISE On je opterećen svojim telom, voli da bude okružen ogledalima, " +
                "a po pravilu uzima mnogo vitaminskih preparata.Često odlazi u solarijum, pa ima " +
                "preplanuo ten.Njegova muškost je u direktnoj vezi s tim kako se oseća i kako izgleda. " +
                "Ako uspete da ga zavedete, biće nežan i pažljiv prema vama, ali, u suprotnom, može da " +
                "bude izuzetno sebičan.";
            sasaText[2]= "VOLIM ALFA MUŠKARACE Alfa muškarac izuzetno voli da se nameće.Njemu je posao na prvom " +
                "mestu. On živi za svaki novi sklopljeni posao.Ume da bude pouzdan u ljubavi, a u braku od " +
                "njega možete da očekujete materijalne pogodnosti.Voli da komanduje, ali ume i da učini da se " +
                "njemu dragi ljudi osete posebnima.";
            sasaText[3]= "VOLIM AUTOSTOPERE To je muškarac koji je uvek spreman za akciju.Putuje često, bez mnogo prtljaga. " +
                "Ima izražen seksepil, ali je za žene izuzetno opasan. On je prosto lud za vezama za jednu noć.Ume da " +
                "voli, ali se retko posvećuje samo jednoj ženi.Njegov kofer je uvek spakovan.Budite sigurni da će " +
                "ovaj čovek obogatiti vaše životno iskustvo. Okolina ga često doživljava kao ekscentričnu osobu.";
            sasaText[4]= "VOLIM ŠALJIVDŽIJE Ovog muškarca je najlakše voleti jer je on zabavan, stalno se smeje, obožava " +
                "žurke i dobar provod.Lud je za publikom, ali je istovremeno sklon melanholiji. On nije vođa, ali " +
                "njemu to ne smeta jer ne teži besprekornoj karijeri. On je postojan i pouzdan prijatelj. Ume da " +
                "bude neodgovoran. U javnosti je uvek nasmejan, ali kad je sam, ume da padne u tešku depresiju.";
            sasaText[5]= "VOLIM TEHNO ZALUĐENIKE On je pravi zaluđenik za tehniku i zna sve o najnovijim tehnološkim " +
                "dostignućima.Najviše vremena provodi ispred kompjutera, ima vešte prste, ali loš vid.On stvarno " +
                "veruje da bi mogao da živi samo u virtuelnom svetu jer je za njega on lepši od stvarnog. " +
                "Pomalo je izgubljen u društvu.";
            string[] message = new string[6];
            message[0] = "VOLIM DETINJASTE Vesela, zaigrana i djeluje poput sunca u dosadnoj svakodnevici. " +
                "Žene koje imaju dječji zaigran karakter s lakoćom osvajaju muškarce. " +
                "No, oprezno s ovom vrstom pažnje. U nekom trenu bi ti se doista mogao početi " +
                "ponašati poput oca, a ne ljubavnog partnera.";
            message[1] = "VOLIM MISTERIOZNE Vjerojatno svaki muškarac pada na neku vrstu misterija. Žena koja " +
                "nikad ne odaje dojam dostupnosti, ona koja ima puno tajni ili jednostavno ne " +
                "voli previše pričati o sebi muškarce intrigira. I jedva čekaju bolje ju upoznati! " +
                "Za uspješnu vezu uvijek ostavi dozu misterija u vezi...";
            message[2] = "VOLIM OVISNICA O SEKSU Je li uopće potrebno govoriti zašto je ovaj tip žene " +
                "muškarcima omiljen? Nema muškarca kojem se ne sviđaju ovakve žene, jer ovako rade " +
                "njihovi osnovni instinkti. No, kolika je vjerojatnost da s ovom ženom želi biti u vezi? " +
                "Ionako ne biste stigli pričati. Jedino što možeš učiniti je da povremeno glumiš ovisnicu.";
            message[3] = "VOLIM NEVINAŠCE Za razliku od ovisnice o seksu koja im je inspiracija kratkoročno, muškarci " +
                "se jako vežu uz žene koje su nevine ili barem glume nevinost. Koliko god zvuči kao floskula koja " +
                "je trebala ostati u 20. stoljeću, muškarci vole glumiti učitelje i otkrivati ti neke nove svjetove. " +
                "Zato se na žene koje glume nevinašce vežu na duje staze. No, nemoj pretjerati u ovom glumatanju, " +
                "jer iako su oni pali s Marsa, neke stvari kuže...";
            message[4] = "VOLIM MILFACE Koliko god odbijale ovu teoriju, muškarci najradije za životnu partnericu biraju " +
                "ženu koja je najsličnija njihovoj majci. Uostalom, oni su velika djeca i treba im osoba koja će " +
                "se za njih brinuti. Edipov kompleks je posebno izražen kod muškaraca koji nisu živjeli sami, nego " +
                "se iz obiteljskog doma presele u zajednički život s mamom, pardon, djevojkom.";
            message[5] = "VOLIM AKTIVNE Ne moraš biti Lara Croft (iako im ni to ne bi bilo loše), ali neka vrsta aktivnosti " +
                "je frajerima itekako napeta. Recimo, čak i obična vožnja bicikla im daje do znanja da si aktivna. " +
                "A ako vodiš aktivan život, pretpostavljaju da si i seksualno aktivna. Što više sportskih aktivnosti " +
                "u kojima si vješta postoji, njima je to više uzbudljivo.";

            Random textRnd = new Random();
            int rndMessageSasa = textRnd.Next(sasaText.Length);
            int rndMassage = textRnd.Next(message.Length);
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;

            if (lastName.Text == "ILICIC")
            {

                aboutYou.Text = sasaText[rndMessageSasa];
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                yourName.Text = "";
                lastName.Text = "";
                year.Text = "";
                

            }
            else
            {
                aboutYou.Text = message[rndMassage];
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                yourName.Text = "";
                lastName.Text = "";
                year.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yourName_TextChanged(object sender, EventArgs e)
        {
            yourName.CharacterCasing = CharacterCasing.Upper;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lastName.CharacterCasing = CharacterCasing.Upper;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
