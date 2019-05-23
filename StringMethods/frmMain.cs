using System;
using System.Windows.Forms;

public class frmMain : Form
{
  private TextBox txtInput;
  private Label label2;
  private TextBox txtLength;
  private Button btnTest;
  private Label label3;
  private TextBox txtToUpper;
  private TextBox txtToLower;
  private Label label4;
  private Button btnClose;
  private Label label5;
  private TextBox txtSearchChar;
  private Label lblIndexOf;
  private TextBox txtSearchIndex;
  private Label label6;
  private TextBox txtStartIndex;
  private Label label7;
  private TextBox txtEndIndex;
  private Label lblSubstring;
  private TextBox txtSubstringResult;
  private TextBox txtLastIndexOf;
  private Label lblLastIndexOf;
  private TextBox txtLastChar;
  private Label label9;
  private TextBox txtReplaceWith;
  private Label label8;
  private TextBox txtReplaceChars;
  private Label label10;
  private TextBox txtRemoveResult;
  private TextBox txtRemove;
  private Label label12;
  private Label label11;
  private TextBox txtReplaceResult;
  private Label label1;
  #region Windows code
  private void InitializeComponent()
  {
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to test:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(193, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(498, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "String.Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(193, 50);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(42, 20);
            this.txtLength.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 337);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(110, 28);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "&Go";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "String.ToUpper():";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(193, 79);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(498, 20);
            this.txtToUpper.TabIndex = 6;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(193, 105);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(498, 20);
            this.txtToLower.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "String.ToLower():";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search for character:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(193, 136);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(24, 20);
            this.txtSearchChar.TabIndex = 11;
            this.txtSearchChar.Text = "v";
            this.txtSearchChar.TextChanged += new System.EventHandler(this.TxtSearchChar_TextChanged);
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.Location = new System.Drawing.Point(223, 135);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(343, 20);
            this.lblIndexOf.TabIndex = 12;
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(572, 135);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(42, 20);
            this.txtSearchIndex.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extract Substring from index:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(193, 194);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(24, 20);
            this.txtStartIndex.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(223, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "for this many characters";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(356, 193);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(24, 20);
            this.txtEndIndex.TabIndex = 17;
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(386, 192);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(180, 20);
            this.lblSubstring.TabIndex = 18;
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(572, 192);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(119, 20);
            this.txtSubstringResult.TabIndex = 19;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(572, 159);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(42, 20);
            this.txtLastIndexOf.TabIndex = 23;
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(223, 159);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(343, 20);
            this.lblLastIndexOf.TabIndex = 22;
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(193, 160);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(24, 20);
            this.txtLastChar.TabIndex = 21;
            this.txtLastChar.Text = "s";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search for last character:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(370, 267);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(93, 20);
            this.txtReplaceWith.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(276, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Replace with:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(193, 268);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(77, 20);
            this.txtReplaceChars.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Find:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(276, 231);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(415, 20);
            this.txtRemoveResult.TabIndex = 27;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(193, 232);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(77, 20);
            this.txtRemove.TabIndex = 25;
            this.txtRemove.Text = "string";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(12, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "txtInput.Remove() = :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(12, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "txtInput.Replace()";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(193, 294);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(498, 20);
            this.txtReplaceResult.TabIndex = 32;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(706, 393);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Tester";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);
            this.PerformLayout();

  }
  #endregion

  public frmMain()
  {
    InitializeComponent();
  }

  public static void Main()
  {
    frmMain main = new frmMain();
    Application.Run(main);
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
    Close();
  }

  private void btnTest_Click(object sender, EventArgs e)
  {
    bool flag;
    int index;
    int start;
    int howMany;
    string temp;

      lblIndexOf.Text = "";
  
    // Find length
    txtLength.Text = txtInput.Text.Length.ToString(); 
    // Change cases
    txtToUpper.Text = txtInput.Text.ToUpper();
    txtToLower.Text = txtInput.Text.ToLower();

    // Index of
    index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
    lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text + "\", 0) = ";
    txtSearchIndex.Text = index.ToString();

    //LastIndexOf
    index = txtInput.Text.LastIndexOf(txtLastChar.Text);
    lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
    txtLastIndexOf.Text = index.ToString();

    // Substring
    flag = int.TryParse(txtStartIndex.Text, out start);
    if (flag == false)
    {
      MessageBox.Show("Improper numeric input. Re-enter.");
      txtStartIndex.Focus();
      return;
    }
    flag = int.TryParse(txtEndIndex.Text, out howMany);
    if (flag == false)
    {
      MessageBox.Show("Improper numeric input. Re-enter.");
      txtEndIndex.Focus();
      return;
    }
    lblSubstring.Text = "txtInput.Text.Substring(" + start.ToString() + ", " + howMany.ToString()+ ") = ";
    txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);

    // Remove
    temp = txtInput.Text;
    index = temp.IndexOf(txtRemove.Text);
    if (index > 0)
    {
      txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
    }

    // Replace
    temp = txtInput.Text;
    txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);


  }

    private void TxtInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void TxtSearchChar_TextChanged(object sender, EventArgs e)
    {

    }
}