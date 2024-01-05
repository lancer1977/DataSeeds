using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Pathfinder.DocConverter.Exporters;
using Pathfinder.DocConverter.Generators;

namespace PFAExcelToXML
{
    public partial class PickerForm : Form
    {
        public PickerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fp = new OpenFileDialog();;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                sourceTextbox.Text = fp.FileName;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fp = new FolderBrowserDialog(); ;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                destinationTextbox.Text = fp.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceTextbox.Text) || string.IsNullOrEmpty(destinationTextbox.Text))
            {
                MessageBox.Show("Invalid inputs");
                return;
            }

            var runner = new Generator(sourceTextbox.Text,GeneratorType.JSON);
            var names = Worksheet.GetWorksheetNames(sourceTextbox.Text);
            foreach(var item in names)
            {
                RunRunner(runner, new GenericModel()
                {
                    Name = item,
                    Header = item,
                    OutputName = item,
                    Worksheet=item
                });
            }
            RunRunner(runner, new  ClassTraitXml());
            // RunRunner(new  FeatXml());
            // RunRunner(new  MagicItemXml());
            // RunRunner(new  PowerXml());
            // RunRunner(new  SkillXml());
            // RunRunner(new  SpecializationXml());
            // RunRunner(new  SpellXml());
            // RunRunner(new  TraitXml());
            //RunRunner(new ClassXml());

        }


                    private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceTextbox.Text) || string.IsNullOrEmpty(destinationTextbox.Text))
            {
                MessageBox.Show("Invalid inputs");
                return;
            }

            var runner = new Generator(sourceTextbox.Text, GeneratorType.JSON);
            RunRunner(runner, new WeaponFeatureXml());
            // RunRunner(new  FeatXml());
            // RunRunner(new  MagicItemXml());
            // RunRunner(new  PowerXml());
            // RunRunner(new  SkillXml());
            // RunRunner(new  SpecializationXml());
            // RunRunner(new  SpellXml());
            // RunRunner(new  TraitXml());
            //RunRunner(new ClassXml());

        }

        private void RunRunner(IGenerator runner,IGeneratorModel model)
        {
            try
            {
                var destination = destinationTextbox.Text;
               var result =  runner.GenerateData(model);
                var extension = runner.Extension;
                File.WriteAllText(Path.Combine(destination, (model.OutputName + runner.Extension)) , result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void SourceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        //        private void RunEnum(IRun runner)
        //        {
        //            try
        //            {
        //                if (string.IsNullOrEmpty(sourceTextbox.Text) || string.IsNullOrEmpty(destinationTextbox.Text))
        //            {
        //                MessageBox.Show("Invalid inputs");
        //                return;
        //            }

        //            runner.GenerateEnum(destinationTextbox.Text, sourceTextbox.Text);
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //        }
        //}



    }
}
