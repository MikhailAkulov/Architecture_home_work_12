namespace ClinicDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDocument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadClients = new System.Windows.Forms.Button();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.columnHeaderPetId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPetBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadPets = new System.Windows.Forms.Button();
            this.listViewConsultations = new System.Windows.Forms.ListView();
            this.columnHeaderConsultationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderConsultationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadConsultations = new System.Windows.Forms.Button();
            this.buttonShowClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonCreatePet = new System.Windows.Forms.Button();
            this.buttonShowPet = new System.Windows.Forms.Button();
            this.buttonUpdatePet = new System.Windows.Forms.Button();
            this.buttonDeletePet = new System.Windows.Forms.Button();
            this.buttonCreateConsultation = new System.Windows.Forms.Button();
            this.buttonShowConsultation = new System.Windows.Forms.Button();
            this.buttonUpdateConsultation = new System.Windows.Forms.Button();
            this.buttonDeleteConsultation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewClients
            // 
            this.listViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderSurName,
            this.columnHeaderFirstName,
            this.columnHeaderPatronymic,
            this.columnHeaderDocument,
            this.columnHeaderClientBirthday});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 12);
            this.listViewClients.MultiSelect = false;
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(790, 240);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderSurName
            // 
            this.columnHeaderSurName.Text = "Фамилия";
            this.columnHeaderSurName.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            this.columnHeaderPatronymic.Text = "Отчество";
            this.columnHeaderPatronymic.Width = 150;
            // 
            // columnHeaderDocument
            // 
            this.columnHeaderDocument.Text = "Документ";
            this.columnHeaderDocument.Width = 150;
            // 
            // columnHeaderClientBirthday
            // 
            this.columnHeaderClientBirthday.Text = "Дата рождения";
            this.columnHeaderClientBirthday.Width = 150;
            // 
            // buttonLoadClients
            // 
            this.buttonLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadClients.Location = new System.Drawing.Point(12, 258);
            this.buttonLoadClients.Name = "buttonLoadClients";
            this.buttonLoadClients.Size = new System.Drawing.Size(130, 44);
            this.buttonLoadClients.TabIndex = 1;
            this.buttonLoadClients.Text = "Загрузить список клиентов";
            this.buttonLoadClients.UseVisualStyleBackColor = true;
            this.buttonLoadClients.Click += new System.EventHandler(this.buttonLoadClients_Click);
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateClient.Location = new System.Drawing.Point(149, 259);
            this.buttonCreateClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(130, 44);
            this.buttonCreateClient.TabIndex = 2;
            this.buttonCreateClient.Text = "Создать нового клиента";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // listViewPets
            // 
            this.listViewPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPetId,
            this.columnHeaderClientId,
            this.columnHeaderName,
            this.columnHeaderPetBirthday});
            this.listViewPets.FullRowSelect = true;
            this.listViewPets.GridLines = true;
            this.listViewPets.HideSelection = false;
            this.listViewPets.Location = new System.Drawing.Point(12, 310);
            this.listViewPets.MultiSelect = false;
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(790, 241);
            this.listViewPets.TabIndex = 3;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPetId
            // 
            this.columnHeaderPetId.Text = "Id Питимца";
            this.columnHeaderPetId.Width = 140;
            // 
            // columnHeaderClientId
            // 
            this.columnHeaderClientId.Text = "Id Владельца";
            this.columnHeaderClientId.Width = 140;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Кличка Питомца";
            this.columnHeaderName.Width = 250;
            // 
            // columnHeaderPetBirthday
            // 
            this.columnHeaderPetBirthday.Text = "Дата рождения питомца";
            this.columnHeaderPetBirthday.Width = 250;
            // 
            // buttonLoadPets
            // 
            this.buttonLoadPets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadPets.Location = new System.Drawing.Point(12, 557);
            this.buttonLoadPets.Name = "buttonLoadPets";
            this.buttonLoadPets.Size = new System.Drawing.Size(130, 44);
            this.buttonLoadPets.TabIndex = 4;
            this.buttonLoadPets.Text = "Загрузить список питомцев";
            this.buttonLoadPets.UseVisualStyleBackColor = true;
            this.buttonLoadPets.Click += new System.EventHandler(this.buttonLoadPets_Click);
            // 
            // listViewConsultations
            // 
            this.listViewConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewConsultations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderConsultationId,
            this.columnHeaderClient,
            this.columnHeaderPet,
            this.columnHeaderConsultationDate,
            this.columnHeaderDescription});
            this.listViewConsultations.FullRowSelect = true;
            this.listViewConsultations.GridLines = true;
            this.listViewConsultations.HideSelection = false;
            this.listViewConsultations.Location = new System.Drawing.Point(12, 607);
            this.listViewConsultations.MultiSelect = false;
            this.listViewConsultations.Name = "listViewConsultations";
            this.listViewConsultations.Size = new System.Drawing.Size(792, 241);
            this.listViewConsultations.TabIndex = 5;
            this.listViewConsultations.UseCompatibleStateImageBehavior = false;
            this.listViewConsultations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderConsultationId
            // 
            this.columnHeaderConsultationId.Text = "Id Консультации";
            this.columnHeaderConsultationId.Width = 120;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Id Клиента";
            this.columnHeaderClient.Width = 130;
            // 
            // columnHeaderPet
            // 
            this.columnHeaderPet.Text = "Id Животного";
            this.columnHeaderPet.Width = 130;
            // 
            // columnHeaderConsultationDate
            // 
            this.columnHeaderConsultationDate.Text = "Дата консультации";
            this.columnHeaderConsultationDate.Width = 200;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Примечание";
            this.columnHeaderDescription.Width = 200;
            // 
            // buttonLoadConsultations
            // 
            this.buttonLoadConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadConsultations.Location = new System.Drawing.Point(12, 854);
            this.buttonLoadConsultations.Name = "buttonLoadConsultations";
            this.buttonLoadConsultations.Size = new System.Drawing.Size(130, 42);
            this.buttonLoadConsultations.TabIndex = 6;
            this.buttonLoadConsultations.Text = "Загрузить список консультаций";
            this.buttonLoadConsultations.UseVisualStyleBackColor = true;
            this.buttonLoadConsultations.Click += new System.EventHandler(this.buttonLoadConsultations_Click);
            // 
            // buttonShowClient
            // 
            this.buttonShowClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowClient.Location = new System.Drawing.Point(286, 258);
            this.buttonShowClient.Name = "buttonShowClient";
            this.buttonShowClient.Size = new System.Drawing.Size(130, 44);
            this.buttonShowClient.TabIndex = 7;
            this.buttonShowClient.Text = "Показать клиента по Id";
            this.buttonShowClient.UseVisualStyleBackColor = true;
            this.buttonShowClient.Click += new System.EventHandler(this.buttonShowClient_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(422, 258);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(130, 44);
            this.buttonUpdateClient.TabIndex = 8;
            this.buttonUpdateClient.Text = "Редактировать запись клиента";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(558, 258);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(130, 44);
            this.buttonDeleteClient.TabIndex = 9;
            this.buttonDeleteClient.Text = "Удалить клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonCreatePet
            // 
            this.buttonCreatePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreatePet.Location = new System.Drawing.Point(149, 557);
            this.buttonCreatePet.Name = "buttonCreatePet";
            this.buttonCreatePet.Size = new System.Drawing.Size(130, 44);
            this.buttonCreatePet.TabIndex = 10;
            this.buttonCreatePet.Text = "Создать нового питомца";
            this.buttonCreatePet.UseVisualStyleBackColor = true;
            this.buttonCreatePet.Click += new System.EventHandler(this.buttonCreatePet_Click);
            // 
            // buttonShowPet
            // 
            this.buttonShowPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowPet.Location = new System.Drawing.Point(286, 557);
            this.buttonShowPet.Name = "buttonShowPet";
            this.buttonShowPet.Size = new System.Drawing.Size(130, 44);
            this.buttonShowPet.TabIndex = 11;
            this.buttonShowPet.Text = "Показать питомца по Id";
            this.buttonShowPet.UseVisualStyleBackColor = true;
            this.buttonShowPet.Click += new System.EventHandler(this.buttonShowPet_Click);
            // 
            // buttonUpdatePet
            // 
            this.buttonUpdatePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdatePet.Location = new System.Drawing.Point(422, 557);
            this.buttonUpdatePet.Name = "buttonUpdatePet";
            this.buttonUpdatePet.Size = new System.Drawing.Size(130, 44);
            this.buttonUpdatePet.TabIndex = 12;
            this.buttonUpdatePet.Text = "Редактировать запись питомца";
            this.buttonUpdatePet.UseVisualStyleBackColor = true;
            this.buttonUpdatePet.Click += new System.EventHandler(this.buttonUpdatePet_Click);
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeletePet.Location = new System.Drawing.Point(558, 557);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Size = new System.Drawing.Size(130, 44);
            this.buttonDeletePet.TabIndex = 13;
            this.buttonDeletePet.Text = "Удалить питомца";
            this.buttonDeletePet.UseVisualStyleBackColor = true;
            this.buttonDeletePet.Click += new System.EventHandler(this.buttonDeletePet_Click);
            // 
            // buttonCreateConsultation
            // 
            this.buttonCreateConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateConsultation.Location = new System.Drawing.Point(149, 854);
            this.buttonCreateConsultation.Name = "buttonCreateConsultation";
            this.buttonCreateConsultation.Size = new System.Drawing.Size(130, 42);
            this.buttonCreateConsultation.TabIndex = 14;
            this.buttonCreateConsultation.Text = "Создать новую консультацию";
            this.buttonCreateConsultation.UseVisualStyleBackColor = true;
            this.buttonCreateConsultation.Click += new System.EventHandler(this.buttonCreateConsultation_Click);
            // 
            // buttonShowConsultation
            // 
            this.buttonShowConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowConsultation.Location = new System.Drawing.Point(286, 854);
            this.buttonShowConsultation.Name = "buttonShowConsultation";
            this.buttonShowConsultation.Size = new System.Drawing.Size(130, 42);
            this.buttonShowConsultation.TabIndex = 15;
            this.buttonShowConsultation.Text = "Показать консультацию по Id";
            this.buttonShowConsultation.UseVisualStyleBackColor = true;
            this.buttonShowConsultation.Click += new System.EventHandler(this.buttonShowConsultation_Click);
            // 
            // buttonUpdateConsultation
            // 
            this.buttonUpdateConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateConsultation.Location = new System.Drawing.Point(422, 854);
            this.buttonUpdateConsultation.Name = "buttonUpdateConsultation";
            this.buttonUpdateConsultation.Size = new System.Drawing.Size(130, 42);
            this.buttonUpdateConsultation.TabIndex = 16;
            this.buttonUpdateConsultation.Text = "Редактировать консультацию";
            this.buttonUpdateConsultation.UseVisualStyleBackColor = true;
            this.buttonUpdateConsultation.Click += new System.EventHandler(this.buttonUpdateConsultation_Click);
            // 
            // buttonDeleteConsultation
            // 
            this.buttonDeleteConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteConsultation.Location = new System.Drawing.Point(558, 854);
            this.buttonDeleteConsultation.Name = "buttonDeleteConsultation";
            this.buttonDeleteConsultation.Size = new System.Drawing.Size(130, 42);
            this.buttonDeleteConsultation.TabIndex = 17;
            this.buttonDeleteConsultation.Text = "Удалить консультацию";
            this.buttonDeleteConsultation.UseVisualStyleBackColor = true;
            this.buttonDeleteConsultation.Click += new System.EventHandler(this.buttonDeleteConsultation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(813, 901);
            this.Controls.Add(this.buttonDeleteConsultation);
            this.Controls.Add(this.buttonUpdateConsultation);
            this.Controls.Add(this.buttonShowConsultation);
            this.Controls.Add(this.buttonCreateConsultation);
            this.Controls.Add(this.buttonDeletePet);
            this.Controls.Add(this.buttonUpdatePet);
            this.Controls.Add(this.buttonShowPet);
            this.Controls.Add(this.buttonCreatePet);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.buttonShowClient);
            this.Controls.Add(this.buttonLoadConsultations);
            this.Controls.Add(this.listViewConsultations);
            this.Controls.Add(this.buttonLoadPets);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.buttonLoadClients);
            this.Controls.Add(this.listViewClients);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя клиника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.Button buttonLoadClients;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderSurName;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronymic;
        private System.Windows.Forms.ColumnHeader columnHeaderDocument;
        private System.Windows.Forms.ColumnHeader columnHeaderClientBirthday;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.ColumnHeader columnHeaderPetId;
        private System.Windows.Forms.ColumnHeader columnHeaderClientId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPetBirthday;
        private System.Windows.Forms.Button buttonLoadPets;
        private System.Windows.Forms.ListView listViewConsultations;
        private System.Windows.Forms.ColumnHeader columnHeaderConsultationId;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ColumnHeader columnHeaderPet;
        private System.Windows.Forms.ColumnHeader columnHeaderConsultationDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button buttonLoadConsultations;
        private System.Windows.Forms.Button buttonShowClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonCreatePet;
        private System.Windows.Forms.Button buttonShowPet;
        private System.Windows.Forms.Button buttonUpdatePet;
        private System.Windows.Forms.Button buttonDeletePet;
        private System.Windows.Forms.Button buttonCreateConsultation;
        private System.Windows.Forms.Button buttonShowConsultation;
        private System.Windows.Forms.Button buttonUpdateConsultation;
        private System.Windows.Forms.Button buttonDeleteConsultation;
    }
}

