using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace L2_login
{
	/// <summary>
	/// Summary description for Language.
	/// </summary>
	public class Language : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.RadioButton radioButton_english;
		private System.Windows.Forms.RadioButton radioButton_portuguese_br;
		private System.Windows.Forms.RadioButton radioButton_japanese;
		private System.Windows.Forms.RadioButton radioButton_french;
		private System.Windows.Forms.RadioButton radioButton_chinese;
		private System.Windows.Forms.RadioButton radioButton_spanish;
		private System.Windows.Forms.RadioButton radioButton_german;
		private System.Windows.Forms.RadioButton radioButton_russian;
		private System.Windows.Forms.Label label_select_lang;
		public L2NET parent_form;
		private System.Windows.Forms.RadioButton radioButton_polish;
		private System.Windows.Forms.RadioButton radioButton_greek;
		private System.Windows.Forms.RadioButton radioButton_korean;
		private System.Windows.Forms.RadioButton radioButton_italian;
		private System.Windows.Forms.RadioButton radioButton_lithuanian;
		private System.Windows.Forms.RadioButton radioButton_dutch;
		private System.Windows.Forms.RadioButton radioButton_romanian;
		private System.Windows.Forms.RadioButton radioButton_leet;
		private System.Windows.Forms.RadioButton radioButton_hungarian;
		private System.Windows.Forms.RadioButton radioButton_marklar;
        private RadioButton radioButton_norwegian;
        private RadioButton radioButton_czech;
        private RadioButton radioButton_slovenian;
        private RadioButton radioButton_swedish;
        private RadioButton radioButton_danish;
        private RadioButton radioButton_portuguese_pt;
        private RadioButton radioButton_finnish;
        private RadioButton radioButton_vietnamese;
        private RadioButton radioButton_thai;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Language()
		{
			InitializeComponent();

			Establish();

			UpdateUI();
		}

		public void UpdateUI()
		{
            this.Text = Globals.m_ResourceManager.GetString("menuItem_language");
            label_select_lang.Text = Globals.m_ResourceManager.GetString("label_select_lang");
            button_save.Text = Globals.m_ResourceManager.GetString("button_save");
            button_cancel.Text = Globals.m_ResourceManager.GetString("button_cancel");
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_english = new System.Windows.Forms.RadioButton();
            this.radioButton_portuguese_br = new System.Windows.Forms.RadioButton();
            this.radioButton_japanese = new System.Windows.Forms.RadioButton();
            this.radioButton_french = new System.Windows.Forms.RadioButton();
            this.radioButton_chinese = new System.Windows.Forms.RadioButton();
            this.radioButton_spanish = new System.Windows.Forms.RadioButton();
            this.radioButton_german = new System.Windows.Forms.RadioButton();
            this.radioButton_russian = new System.Windows.Forms.RadioButton();
            this.label_select_lang = new System.Windows.Forms.Label();
            this.radioButton_polish = new System.Windows.Forms.RadioButton();
            this.radioButton_greek = new System.Windows.Forms.RadioButton();
            this.radioButton_korean = new System.Windows.Forms.RadioButton();
            this.radioButton_italian = new System.Windows.Forms.RadioButton();
            this.radioButton_lithuanian = new System.Windows.Forms.RadioButton();
            this.radioButton_dutch = new System.Windows.Forms.RadioButton();
            this.radioButton_romanian = new System.Windows.Forms.RadioButton();
            this.radioButton_leet = new System.Windows.Forms.RadioButton();
            this.radioButton_hungarian = new System.Windows.Forms.RadioButton();
            this.radioButton_marklar = new System.Windows.Forms.RadioButton();
            this.radioButton_norwegian = new System.Windows.Forms.RadioButton();
            this.radioButton_czech = new System.Windows.Forms.RadioButton();
            this.radioButton_slovenian = new System.Windows.Forms.RadioButton();
            this.radioButton_swedish = new System.Windows.Forms.RadioButton();
            this.radioButton_danish = new System.Windows.Forms.RadioButton();
            this.radioButton_portuguese_pt = new System.Windows.Forms.RadioButton();
            this.radioButton_finnish = new System.Windows.Forms.RadioButton();
            this.radioButton_vietnamese = new System.Windows.Forms.RadioButton();
            this.radioButton_thai = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_save.Location = new System.Drawing.Point(8, 367);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 28);
            this.button_save.TabIndex = 24;
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_cancel.Location = new System.Drawing.Point(120, 367);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(96, 28);
            this.button_cancel.TabIndex = 25;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_english
            // 
            this.radioButton_english.Location = new System.Drawing.Point(8, 30);
            this.radioButton_english.Name = "radioButton_english";
            this.radioButton_english.Size = new System.Drawing.Size(104, 24);
            this.radioButton_english.TabIndex = 0;
            this.radioButton_english.Text = "English";
            // 
            // radioButton_portuguese_br
            // 
            this.radioButton_portuguese_br.Location = new System.Drawing.Point(8, 52);
            this.radioButton_portuguese_br.Name = "radioButton_portuguese_br";
            this.radioButton_portuguese_br.Size = new System.Drawing.Size(104, 24);
            this.radioButton_portuguese_br.TabIndex = 1;
            this.radioButton_portuguese_br.Text = "Portugues BR";
            // 
            // radioButton_japanese
            // 
            this.radioButton_japanese.Location = new System.Drawing.Point(120, 244);
            this.radioButton_japanese.Name = "radioButton_japanese";
            this.radioButton_japanese.Size = new System.Drawing.Size(104, 21);
            this.radioButton_japanese.TabIndex = 20;
            this.radioButton_japanese.Text = "日本語";
            // 
            // radioButton_french
            // 
            this.radioButton_french.Location = new System.Drawing.Point(8, 100);
            this.radioButton_french.Name = "radioButton_french";
            this.radioButton_french.Size = new System.Drawing.Size(104, 24);
            this.radioButton_french.TabIndex = 3;
            this.radioButton_french.Text = "Français";
            // 
            // radioButton_chinese
            // 
            this.radioButton_chinese.Location = new System.Drawing.Point(120, 268);
            this.radioButton_chinese.Name = "radioButton_chinese";
            this.radioButton_chinese.Size = new System.Drawing.Size(104, 21);
            this.radioButton_chinese.TabIndex = 21;
            this.radioButton_chinese.Text = "中文";
            // 
            // radioButton_spanish
            // 
            this.radioButton_spanish.Location = new System.Drawing.Point(8, 124);
            this.radioButton_spanish.Name = "radioButton_spanish";
            this.radioButton_spanish.Size = new System.Drawing.Size(104, 24);
            this.radioButton_spanish.TabIndex = 4;
            this.radioButton_spanish.Text = "Español";
            // 
            // radioButton_german
            // 
            this.radioButton_german.Location = new System.Drawing.Point(8, 172);
            this.radioButton_german.Name = "radioButton_german";
            this.radioButton_german.Size = new System.Drawing.Size(104, 24);
            this.radioButton_german.TabIndex = 6;
            this.radioButton_german.Text = "Deutsch";
            // 
            // radioButton_russian
            // 
            this.radioButton_russian.Location = new System.Drawing.Point(120, 148);
            this.radioButton_russian.Name = "radioButton_russian";
            this.radioButton_russian.Size = new System.Drawing.Size(104, 21);
            this.radioButton_russian.TabIndex = 17;
            this.radioButton_russian.Text = "Русский";
            // 
            // label_select_lang
            // 
            this.label_select_lang.Location = new System.Drawing.Point(0, 0);
            this.label_select_lang.Name = "label_select_lang";
            this.label_select_lang.Size = new System.Drawing.Size(232, 32);
            this.label_select_lang.TabIndex = 10;
            this.label_select_lang.Text = "Select Language";
            this.label_select_lang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_polish
            // 
            this.radioButton_polish.Location = new System.Drawing.Point(8, 196);
            this.radioButton_polish.Name = "radioButton_polish";
            this.radioButton_polish.Size = new System.Drawing.Size(104, 24);
            this.radioButton_polish.TabIndex = 7;
            this.radioButton_polish.Text = "Polski";
            // 
            // radioButton_greek
            // 
            this.radioButton_greek.Location = new System.Drawing.Point(120, 172);
            this.radioButton_greek.Name = "radioButton_greek";
            this.radioButton_greek.Size = new System.Drawing.Size(104, 21);
            this.radioButton_greek.TabIndex = 18;
            this.radioButton_greek.Text = "Ελληνικά";
            // 
            // radioButton_korean
            // 
            this.radioButton_korean.Location = new System.Drawing.Point(120, 220);
            this.radioButton_korean.Name = "radioButton_korean";
            this.radioButton_korean.Size = new System.Drawing.Size(104, 21);
            this.radioButton_korean.TabIndex = 19;
            this.radioButton_korean.Text = "한국어";
            // 
            // radioButton_italian
            // 
            this.radioButton_italian.Location = new System.Drawing.Point(8, 148);
            this.radioButton_italian.Name = "radioButton_italian";
            this.radioButton_italian.Size = new System.Drawing.Size(104, 24);
            this.radioButton_italian.TabIndex = 5;
            this.radioButton_italian.Text = "Italiano";
            // 
            // radioButton_lithuanian
            // 
            this.radioButton_lithuanian.Location = new System.Drawing.Point(120, 124);
            this.radioButton_lithuanian.Name = "radioButton_lithuanian";
            this.radioButton_lithuanian.Size = new System.Drawing.Size(104, 21);
            this.radioButton_lithuanian.TabIndex = 16;
            this.radioButton_lithuanian.Text = "Lietuvių";
            // 
            // radioButton_dutch
            // 
            this.radioButton_dutch.Location = new System.Drawing.Point(120, 100);
            this.radioButton_dutch.Name = "radioButton_dutch";
            this.radioButton_dutch.Size = new System.Drawing.Size(104, 21);
            this.radioButton_dutch.TabIndex = 15;
            this.radioButton_dutch.Text = "Nederlands";
            // 
            // radioButton_romanian
            // 
            this.radioButton_romanian.Location = new System.Drawing.Point(8, 220);
            this.radioButton_romanian.Name = "radioButton_romanian";
            this.radioButton_romanian.Size = new System.Drawing.Size(104, 24);
            this.radioButton_romanian.TabIndex = 8;
            this.radioButton_romanian.Text = "Română";
            // 
            // radioButton_leet
            // 
            this.radioButton_leet.Location = new System.Drawing.Point(120, 292);
            this.radioButton_leet.Name = "radioButton_leet";
            this.radioButton_leet.Size = new System.Drawing.Size(104, 21);
            this.radioButton_leet.TabIndex = 22;
            this.radioButton_leet.Text = "1337";
            // 
            // radioButton_hungarian
            // 
            this.radioButton_hungarian.Location = new System.Drawing.Point(8, 244);
            this.radioButton_hungarian.Name = "radioButton_hungarian";
            this.radioButton_hungarian.Size = new System.Drawing.Size(104, 24);
            this.radioButton_hungarian.TabIndex = 9;
            this.radioButton_hungarian.Text = "Hungarian";
            // 
            // radioButton_marklar
            // 
            this.radioButton_marklar.Location = new System.Drawing.Point(120, 316);
            this.radioButton_marklar.Name = "radioButton_marklar";
            this.radioButton_marklar.Size = new System.Drawing.Size(104, 21);
            this.radioButton_marklar.TabIndex = 23;
            this.radioButton_marklar.Text = "marklar";
            // 
            // radioButton_norwegian
            // 
            this.radioButton_norwegian.Location = new System.Drawing.Point(8, 268);
            this.radioButton_norwegian.Name = "radioButton_norwegian";
            this.radioButton_norwegian.Size = new System.Drawing.Size(104, 24);
            this.radioButton_norwegian.TabIndex = 10;
            this.radioButton_norwegian.Text = "Norsk";
            // 
            // radioButton_czech
            // 
            this.radioButton_czech.Location = new System.Drawing.Point(8, 292);
            this.radioButton_czech.Name = "radioButton_czech";
            this.radioButton_czech.Size = new System.Drawing.Size(104, 24);
            this.radioButton_czech.TabIndex = 11;
            this.radioButton_czech.Text = "Čeština";
            // 
            // radioButton_slovenian
            // 
            this.radioButton_slovenian.Location = new System.Drawing.Point(120, 76);
            this.radioButton_slovenian.Name = "radioButton_slovenian";
            this.radioButton_slovenian.Size = new System.Drawing.Size(104, 21);
            this.radioButton_slovenian.TabIndex = 14;
            this.radioButton_slovenian.Text = "Slovenščina";
            // 
            // radioButton_swedish
            // 
            this.radioButton_swedish.Location = new System.Drawing.Point(120, 52);
            this.radioButton_swedish.Name = "radioButton_swedish";
            this.radioButton_swedish.Size = new System.Drawing.Size(104, 21);
            this.radioButton_swedish.TabIndex = 13;
            this.radioButton_swedish.Text = "Svenska";
            // 
            // radioButton_danish
            // 
            this.radioButton_danish.Location = new System.Drawing.Point(120, 30);
            this.radioButton_danish.Name = "radioButton_danish";
            this.radioButton_danish.Size = new System.Drawing.Size(104, 24);
            this.radioButton_danish.TabIndex = 12;
            this.radioButton_danish.Text = "Dansk";
            // 
            // radioButton_portuguese_pt
            // 
            this.radioButton_portuguese_pt.Location = new System.Drawing.Point(8, 76);
            this.radioButton_portuguese_pt.Name = "radioButton_portuguese_pt";
            this.radioButton_portuguese_pt.Size = new System.Drawing.Size(104, 24);
            this.radioButton_portuguese_pt.TabIndex = 2;
            this.radioButton_portuguese_pt.Text = "Portugues PT";
            // 
            // radioButton_finnish
            // 
            this.radioButton_finnish.Location = new System.Drawing.Point(8, 316);
            this.radioButton_finnish.Name = "radioButton_finnish";
            this.radioButton_finnish.Size = new System.Drawing.Size(104, 24);
            this.radioButton_finnish.TabIndex = 26;
            this.radioButton_finnish.Text = "suomi";
            // 
            // radioButton_vietnamese
            // 
            this.radioButton_vietnamese.Location = new System.Drawing.Point(120, 196);
            this.radioButton_vietnamese.Name = "radioButton_vietnamese";
            this.radioButton_vietnamese.Size = new System.Drawing.Size(104, 21);
            this.radioButton_vietnamese.TabIndex = 27;
            this.radioButton_vietnamese.Text = "Tiếng Việt";
            // 
            // radioButton_thai
            // 
            this.radioButton_thai.Location = new System.Drawing.Point(8, 340);
            this.radioButton_thai.Name = "radioButton_thai";
            this.radioButton_thai.Size = new System.Drawing.Size(104, 24);
            this.radioButton_thai.TabIndex = 28;
            this.radioButton_thai.Text = "ภาษาไทย";
            // 
            // Language
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(226, 401);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton_thai);
            this.Controls.Add(this.radioButton_vietnamese);
            this.Controls.Add(this.radioButton_finnish);
            this.Controls.Add(this.radioButton_portuguese_pt);
            this.Controls.Add(this.radioButton_danish);
            this.Controls.Add(this.radioButton_swedish);
            this.Controls.Add(this.radioButton_slovenian);
            this.Controls.Add(this.radioButton_czech);
            this.Controls.Add(this.radioButton_norwegian);
            this.Controls.Add(this.radioButton_marklar);
            this.Controls.Add(this.radioButton_hungarian);
            this.Controls.Add(this.radioButton_leet);
            this.Controls.Add(this.radioButton_romanian);
            this.Controls.Add(this.radioButton_dutch);
            this.Controls.Add(this.radioButton_lithuanian);
            this.Controls.Add(this.radioButton_italian);
            this.Controls.Add(this.radioButton_korean);
            this.Controls.Add(this.radioButton_greek);
            this.Controls.Add(this.radioButton_polish);
            this.Controls.Add(this.label_select_lang);
            this.Controls.Add(this.radioButton_russian);
            this.Controls.Add(this.radioButton_german);
            this.Controls.Add(this.radioButton_spanish);
            this.Controls.Add(this.radioButton_chinese);
            this.Controls.Add(this.radioButton_french);
            this.Controls.Add(this.radioButton_japanese);
            this.Controls.Add(this.radioButton_portuguese_br);
            this.Controls.Add(this.radioButton_english);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Language";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language";
            this.TopMost = true;
            this.ResumeLayout(false);

		}
		#endregion

		private void Establish()
		{
            switch(Globals.LanuageSet)
            {
                case 0:
                    radioButton_english.Checked = true;
                    break;
                case 1:
                    radioButton_portuguese_br.Checked = true;
                    break;
                case 2:
                    radioButton_french.Checked = true;
                    break;
                case 3:
                    radioButton_spanish.Checked = true;
                    break;
                case 4:
                    radioButton_german.Checked = true;
                    break;
                case 5:
                    radioButton_polish.Checked = true;
                    break;
                case 6:
                    radioButton_russian.Checked = true;
                    break;
                case 7:
                    radioButton_japanese.Checked = true;
                    break;
                case 8:
                    radioButton_chinese.Checked = true;
                    break;
                case 9:
                    radioButton_greek.Checked = true;
                    break;
                case 10:
                    radioButton_korean.Checked = true;
                    break;
                case 11:
                    radioButton_italian.Checked = true;
                    break;
                case 12:
                    radioButton_lithuanian.Checked = true;
                    break;
                case 13:
                    radioButton_dutch.Checked = true;
                    break;
                case 14:
                    radioButton_romanian.Checked = true;
                    break;
                case 15:
                    radioButton_leet.Checked = true;
                    break;
                case 16:
                    radioButton_hungarian.Checked = true;
                    break;
                case 17:
                    radioButton_marklar.Checked = true;
                    break;
                case 18:
                    radioButton_norwegian.Checked = true;
                    break;
                case 19:
                    radioButton_czech.Checked = true;
                    break;
                case 20:
                    radioButton_slovenian.Checked = true;
                    break;
                case 21:
                    radioButton_swedish.Checked = true;
                    break;
                case 22:
                    radioButton_danish.Checked = true;
                    break;
                case 23:
                    radioButton_portuguese_pt.Checked = true;
                    break;
                case 24:
                    radioButton_finnish.Checked = true;
                    break;
                case 25:
                    radioButton_vietnamese.Checked = true;
                    break;
                case 26:
                    radioButton_thai.Checked = true;
                    break;
            }
		}

		private void button_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button_save_Click(object sender, System.EventArgs e)
		{
			//need to commit the language
			if(radioButton_english.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.English", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 0;
			}
			if(radioButton_portuguese_br.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.PortugueseBR", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 1;
            }
			if(radioButton_french.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.French", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 2;
            }
			if(radioButton_spanish.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Spanish", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 3;
            }
			if(radioButton_german.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.German", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 4;
            }
			if(radioButton_polish.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Polish", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 5;
            }
			if(radioButton_russian.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Russian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 6;
            }
			if(radioButton_japanese.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Japanese", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 7;
            }
			if(radioButton_chinese.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Chinese", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 8;
            }
			if(radioButton_greek.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Greek", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 9;
            }
			if(radioButton_korean.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Korean", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 10;
            }
			if(radioButton_italian.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Italian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 11;
            }
			if(radioButton_lithuanian.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Lithuanian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 12;
            }
			if(radioButton_dutch.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Dutch", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 13;
            }
			if(radioButton_romanian.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Romanian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 14;
            }
			if(radioButton_leet.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Leet", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 15;
            }
			if(radioButton_hungarian.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Hungarian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 16;
            }
			if(radioButton_marklar.Checked)
			{
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Marklar", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 17;
            }
            if (radioButton_norwegian.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Norwegian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 18;
            }
            if (radioButton_czech.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Czech", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 19;
            }
            if (radioButton_slovenian.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Slovenian", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 20;
            }
            if (radioButton_swedish.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Swedish", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 21;
            }
            if (radioButton_danish.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Danish", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 22;
            }
            if (radioButton_portuguese_pt.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.PortuguesePT", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 23;
            }
            if (radioButton_finnish.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Finnish", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 24;
            }
            if (radioButton_vietnamese.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Vietnamese", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 25;
            }
            if (radioButton_thai.Checked)
            {
                Globals.m_ResourceManager = new System.Resources.ResourceManager("L2_login.Languages.Thai", System.Reflection.Assembly.GetExecutingAssembly());
                Globals.LanuageSet = 26;
            }

			parent_form.UpdateUI();
            if (Globals.login_window != null)
                Globals.login_window.UpdateUI();
            if (Globals.botoptionsscreen != null)
                Globals.botoptionsscreen.UpdateUI();
            if (Globals.setupwindow != null)
                Globals.setupwindow.UpdateUI();
			this.Close();
		}
	}//end of class
}
