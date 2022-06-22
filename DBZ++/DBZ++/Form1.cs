using System.Text.RegularExpressions;

namespace DBZ__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String reservedWordTable(String strToken)
        {
            switch (strToken)
            {
                case "bucle_for": return " per";
                case "inicio_condicion": return " {";
                case "condicion": return "condicion";
                case "fin_condicion": return " }";
                case "inicio_instruccion": return " [";
                case "instruccion": return "instruccion";
                case "fin_instruccion": return " ]";
                case "bloque_complit": return "complit";
                case "variable": return "nombre de la variable";
                case "variable_comparacion": return " =";
                case "valor_variable": return " valor de la variable";
                case "tipo_variable_literal": return "literal";
                case "tipo_variable": return "tipo de la variable";
                case "fin_expresion": return "punto";
                default: return "None " + strToken;
            }
        }

        private void txtSourceCode_TextChanged(object sender, EventArgs e)
        {
            validateCode();
            LinesNumber();
        }
        private void LinesNumber()
        {
            int numLines = txtCodFuente.Lines.Count();
            listNumberLines.Items.Clear();

            for (int i = 1; i <= numLines; i++)
            {
                listNumberLines.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinesNumber();
        }

        private void btnRunRun_Click(object sender, EventArgs e)
        {
            validateCode();
           // int a = 0;
        }
        private void validateCode()
        {
            String messageValidate = "";

            String strValFunction = @"(?<bucle_for>[a-zA-Z]*)\s*(?<inicio_condicion>\{{0,1})(?<condicion>.*\+)\s*(?<fin_condicion>\}{0,1})(?<inicio_instruccion>\[{0,1})";
            Regex rxValFunction = new Regex(strValFunction, RegexOptions.Compiled | RegexOptions.Singleline);
            
            String strValVarDefinitions4 = @"^(?<tipo_variables>[a-zA-Z]*)\s*(?<nombre_variables>\w*)\s*(?<variable_comparacion>\={0,1})\s*(?<inicio_literal>\|{0,1})\s*(?<contenido_literal>[a-zA-Z0-9]*)\s*(?<fin_literal>\|{0,1})(?<fin_expresion>\.{0,1}$)";
            Regex rxValVarDefinition4 = new Regex(strValVarDefinitions4, RegexOptions.Compiled | RegexOptions.Singleline);

            String strValVarDefinitions = @"(?<tipo_variable>[a-zA-Z]*)\s(?<variable>[a-zA-Z0-9]*)\s*(?<variable_comparacion>={0,1})\s*(?<valor_variable>[0-9]*)\s*(?<fin_expresion>\.{0,1})";
            Regex rxValVarDefinition = new Regex(strValVarDefinitions, RegexOptions.Compiled | RegexOptions.Singleline);

            String strValVarDefinitions3 = @"^.*(?<fin_instruccion>\]{0,1}).*";
            Regex rxValVarDefinition3 = new Regex(strValVarDefinitions3, RegexOptions.Compiled | RegexOptions.Singleline);

            

            txtResult2.Text = "";
            String StringtrimCurrentLine = "";
            int Cont = 0;
            foreach (String currentLine in txtCodFuente.Lines)
            {
                Cont++;
                StringtrimCurrentLine = currentLine.Trim();
                if (StringtrimCurrentLine.Length == 0)
                {                   
                    continue;
                }
                Match match = rxValFunction.Match(currentLine);
                Match match4 = rxValVarDefinition4.Match(currentLine);
                Match matchVarDef = rxValVarDefinition.Match(currentLine);
                Match match3 = rxValVarDefinition3.Match(currentLine);
                


                GroupCollection groups = match.Groups;

                if (match.Success)
                {
                    foreach (Group groupValid in match.Groups)
                    {
                        if (groupValid.Value.Length == 0 && groupValid.Name.Length > 0)
                        {
                            messageValidate += Cont + " IF 1 Esta faltando un" + reservedWordTable(groupValid.Name) + "\n";
                        }                        
                    }                    
                    txtResult2.Text = messageValidate;
                }
                 else if (matchVarDef.Success)
                {
                    foreach (Group groupValid in matchVarDef.Groups )
                    {
                        if (groupValid.Value.Length == 0 && groupValid.Name.Length > 0 && groupValid.Name != "0")
                        {
                            messageValidate += Cont + " IF 2 Esta faltando un " + reservedWordTable(groupValid.Name) + "\n";
                        }                        
                    }                   
                    txtResult2.Text = messageValidate;
                }
                else if (match3.Success)
                {
                    foreach (Group groupValid in groups)
                    {
                        
                        //if ( groupValid.Value.Length == 0 && groupValid.Name.Length>0 && groupValid.Name!="0" )
                        if (groupValid.Value.Length == 0 && groupValid.Name.Length > 0 &&  groupValid.Name != "0") 
                        {
                            messageValidate += Cont +  " Falta " + reservedWordTable(groupValid.Name) + groupValid.Value+"\n";                            
                        }

                    }

                    txtResult2.Text = messageValidate;
                }
              
                if (match4.Success)
                {
                    foreach (Group groupValid in groups)
                    {

                        //if ( groupValid.Value.Length == 0 && groupValid.Name.Length>0 && groupValid.Name!="0" )
                        if (groupValid.Value.Length == 0 && groupValid.Name.Length > 0 && groupValid.Name != "0")
                        {
                            messageValidate += Cont + " Falta " + reservedWordTable(groupValid.Name) + groupValid.Value + "\n";
                        }

                    }

                    txtResult2.Text = messageValidate;
                }

                else 
                {
                    //txtResultList.Items.Add("Funcion Error" + currentLine);
                }


            }
            messageValidate = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //analizador lexico
        private void button1_Click(object sender, EventArgs e)
        {
            String CodFuente= txtCodFuente.Text;            
            String strPatron2 = @"(?<tipo_variable>[a-zA-Z0-9]+)\s*(?<nombre_variable>[a-zA-Z0-9]+)\s*(?<variable_comparacion>\=)\s*(?<valor_variable>\d+)(?<fin_expresion>\.)";

            String strPatron = @"(?<bucle_for>[a-zA-Z]*)\s*(?<inicio_condicion>\{{0,1})(?<condicion>.*\+)\s*(?<fin_condicion>\}{0,1})(?<inicio_instruccion>\[{0,1})\n*(?<tipo_variable>\w*)\s*(?<nombre_variable>\w+)\s*(?<variable_comparacion>\=)\s*(?<valor_variable>\d+)(?<fin_expresion>\.)\n*\s*(?<fin_instruccion>\])";

            String strPatron3 = @"(?<tipo_variable>\bliteral\b)\s*(?<nombre_variable>\w*)\s*(?<variable_comparacion>\=)\s*(?<inicio_literal>\|)(?<contenido_literal>\s*.+)(?<fin_literal>\|)(?<fin_expresion>\.)";


            Regex rx = new Regex(strPatron, RegexOptions.Compiled | RegexOptions.Multiline);
            Regex rx2 = new Regex(strPatron2, RegexOptions.Compiled | RegexOptions.Multiline);
            Regex rx3 = new Regex(strPatron3, RegexOptions.Compiled | RegexOptions.Multiline);


            MatchCollection matches = rx.Matches(CodFuente);
            MatchCollection matches2 = rx2.Matches(CodFuente);
            MatchCollection matches3 = rx3.Matches(CodFuente);


            dgvTokens.Rows.Clear();
            int contador = 0;
            foreach (Match matchItem in matches)
            {                
                if (matchItem.Success)
                {
                    GroupCollection groups = matchItem.Groups;
                    foreach (Group groupItem in groups)
                    {
                        dgvTokens.Rows.Insert(contador,groupItem.Index, groupItem.Value, groupItem.Name);
                        contador++;
                    }
                }     
                else
                {
                    MessageBox.Show("Expresion no válida", "Warning");
                }

            }

            foreach (Match matchItem2 in matches2)
            {

                if (matchItem2.Success)
                {
                    GroupCollection groups = matchItem2.Groups;
                    foreach (Group groupItem in groups)
                    {
                        dgvTokens.Rows.Insert(contador, groupItem.Index, groupItem.Value, groupItem.Name);
                        contador++;
                    }
                }
                else
                {
                    MessageBox.Show("Expresion no válida", "Warning");
                }
            }

            foreach (Match matchItem3 in matches3)
            {

                if (matchItem3.Success)
                {
                    GroupCollection groups = matchItem3.Groups;
                    foreach (Group groupItem in groups)
                    {
                        dgvTokens.Rows.Insert(contador, groupItem.Index, groupItem.Value, groupItem.Name);
                        contador++;
                    }
                }
                else
                {
                    MessageBox.Show("Expresion no válida", "Warning");
                }
            }



        }
    }
}