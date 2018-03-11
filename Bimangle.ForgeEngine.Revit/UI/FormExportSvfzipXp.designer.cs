﻿namespace Bimangle.ForgeEngine.Revit.UI
{
    partial class FormExportSvfzipXp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportSvfzipXp));
            this.btnOK = new System.Windows.Forms.Button();
            this.gpContainer = new System.Windows.Forms.GroupBox();
            this.cbUseCurrentViewport = new System.Windows.Forms.CheckBox();
            this.gpGeneral = new System.Windows.Forms.GroupBox();
            this.cbVisualStyle = new System.Windows.Forms.ComboBox();
            this.lblVisualStyle = new System.Windows.Forms.Label();
            this.cbLevelOfDetail = new System.Windows.Forms.ComboBox();
            this.lblLevelOfDetail = new System.Windows.Forms.Label();
            this.gpGenerate = new System.Windows.Forms.GroupBox();
            this.cbGeneratePropDbSqlite = new System.Windows.Forms.CheckBox();
            this.cbGeneratePropDbJson = new System.Windows.Forms.CheckBox();
            this.cbGenerateThumbnail = new System.Windows.Forms.CheckBox();
            this.gpInclude = new System.Windows.Forms.GroupBox();
            this.cbIncludeRooms = new System.Windows.Forms.CheckBox();
            this.cbIncludeGrids = new System.Windows.Forms.CheckBox();
            this.gpExclude = new System.Windows.Forms.GroupBox();
            this.cbExcludeUnselectedElements = new System.Windows.Forms.CheckBox();
            this.cbExcludeModelPoints = new System.Windows.Forms.CheckBox();
            this.cbExcludeLines = new System.Windows.Forms.CheckBox();
            this.cbExcludeElementProperties = new System.Windows.Forms.CheckBox();
            this.gpConsolidate = new System.Windows.Forms.GroupBox();
            this.cbConsolidateAssembly = new System.Windows.Forms.CheckBox();
            this.cbConsolidateArrayGroup = new System.Windows.Forms.CheckBox();
            this.gp2DViews = new System.Windows.Forms.GroupBox();
            this.rb2DViewsAll = new System.Windows.Forms.RadioButton();
            this.rb2DViewsOnlySheet = new System.Windows.Forms.RadioButton();
            this.rb2DViewsBypass = new System.Windows.Forms.RadioButton();
            this.gpGroupByLevel = new System.Windows.Forms.GroupBox();
            this.rbGroupByLevelBoundingBox = new System.Windows.Forms.RadioButton();
            this.rbGroupByLevelNavisworks = new System.Windows.Forms.RadioButton();
            this.rbGroupByLevelDefault = new System.Windows.Forms.RadioButton();
            this.rbGroupByLevelDisable = new System.Windows.Forms.RadioButton();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLicense = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnResetOptions = new System.Windows.Forms.Button();
            this.gpContainer.SuspendLayout();
            this.gpGeneral.SuspendLayout();
            this.gpGenerate.SuspendLayout();
            this.gpInclude.SuspendLayout();
            this.gpExclude.SuspendLayout();
            this.gpConsolidate.SuspendLayout();
            this.gp2DViews.SuspendLayout();
            this.gpGroupByLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gpContainer
            // 
            resources.ApplyResources(this.gpContainer, "gpContainer");
            this.gpContainer.Controls.Add(this.cbUseCurrentViewport);
            this.gpContainer.Controls.Add(this.gpGeneral);
            this.gpContainer.Controls.Add(this.gpGenerate);
            this.gpContainer.Controls.Add(this.gpInclude);
            this.gpContainer.Controls.Add(this.gpExclude);
            this.gpContainer.Controls.Add(this.gpConsolidate);
            this.gpContainer.Controls.Add(this.gp2DViews);
            this.gpContainer.Controls.Add(this.gpGroupByLevel);
            this.gpContainer.Controls.Add(this.lblOptions);
            this.gpContainer.Controls.Add(this.btnBrowse);
            this.gpContainer.Controls.Add(this.txtTargetPath);
            this.gpContainer.Controls.Add(this.lblOutputPath);
            this.gpContainer.Name = "gpContainer";
            this.gpContainer.TabStop = false;
            // 
            // cbUseCurrentViewport
            // 
            resources.ApplyResources(this.cbUseCurrentViewport, "cbUseCurrentViewport");
            this.cbUseCurrentViewport.Name = "cbUseCurrentViewport";
            this.cbUseCurrentViewport.UseVisualStyleBackColor = true;
            // 
            // gpGeneral
            // 
            this.gpGeneral.Controls.Add(this.cbVisualStyle);
            this.gpGeneral.Controls.Add(this.lblVisualStyle);
            this.gpGeneral.Controls.Add(this.cbLevelOfDetail);
            this.gpGeneral.Controls.Add(this.lblLevelOfDetail);
            resources.ApplyResources(this.gpGeneral, "gpGeneral");
            this.gpGeneral.Name = "gpGeneral";
            this.gpGeneral.TabStop = false;
            // 
            // cbVisualStyle
            // 
            this.cbVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisualStyle.FormattingEnabled = true;
            resources.ApplyResources(this.cbVisualStyle, "cbVisualStyle");
            this.cbVisualStyle.Name = "cbVisualStyle";
            this.cbVisualStyle.SelectedIndexChanged += new System.EventHandler(this.cbVisualStyle_SelectedIndexChanged);
            // 
            // lblVisualStyle
            // 
            resources.ApplyResources(this.lblVisualStyle, "lblVisualStyle");
            this.lblVisualStyle.Name = "lblVisualStyle";
            // 
            // cbLevelOfDetail
            // 
            this.cbLevelOfDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevelOfDetail.FormattingEnabled = true;
            resources.ApplyResources(this.cbLevelOfDetail, "cbLevelOfDetail");
            this.cbLevelOfDetail.Name = "cbLevelOfDetail";
            // 
            // lblLevelOfDetail
            // 
            resources.ApplyResources(this.lblLevelOfDetail, "lblLevelOfDetail");
            this.lblLevelOfDetail.Name = "lblLevelOfDetail";
            // 
            // gpGenerate
            // 
            this.gpGenerate.Controls.Add(this.cbGeneratePropDbSqlite);
            this.gpGenerate.Controls.Add(this.cbGeneratePropDbJson);
            this.gpGenerate.Controls.Add(this.cbGenerateThumbnail);
            resources.ApplyResources(this.gpGenerate, "gpGenerate");
            this.gpGenerate.Name = "gpGenerate";
            this.gpGenerate.TabStop = false;
            // 
            // cbGeneratePropDbSqlite
            // 
            resources.ApplyResources(this.cbGeneratePropDbSqlite, "cbGeneratePropDbSqlite");
            this.cbGeneratePropDbSqlite.Name = "cbGeneratePropDbSqlite";
            this.cbGeneratePropDbSqlite.UseVisualStyleBackColor = true;
            // 
            // cbGeneratePropDbJson
            // 
            resources.ApplyResources(this.cbGeneratePropDbJson, "cbGeneratePropDbJson");
            this.cbGeneratePropDbJson.Name = "cbGeneratePropDbJson";
            this.cbGeneratePropDbJson.UseVisualStyleBackColor = true;
            // 
            // cbGenerateThumbnail
            // 
            resources.ApplyResources(this.cbGenerateThumbnail, "cbGenerateThumbnail");
            this.cbGenerateThumbnail.Name = "cbGenerateThumbnail";
            this.cbGenerateThumbnail.UseVisualStyleBackColor = true;
            // 
            // gpInclude
            // 
            this.gpInclude.Controls.Add(this.cbIncludeRooms);
            this.gpInclude.Controls.Add(this.cbIncludeGrids);
            resources.ApplyResources(this.gpInclude, "gpInclude");
            this.gpInclude.Name = "gpInclude";
            this.gpInclude.TabStop = false;
            // 
            // cbIncludeRooms
            // 
            resources.ApplyResources(this.cbIncludeRooms, "cbIncludeRooms");
            this.cbIncludeRooms.Name = "cbIncludeRooms";
            this.cbIncludeRooms.UseVisualStyleBackColor = true;
            // 
            // cbIncludeGrids
            // 
            resources.ApplyResources(this.cbIncludeGrids, "cbIncludeGrids");
            this.cbIncludeGrids.Name = "cbIncludeGrids";
            this.cbIncludeGrids.UseVisualStyleBackColor = true;
            // 
            // gpExclude
            // 
            this.gpExclude.Controls.Add(this.cbExcludeUnselectedElements);
            this.gpExclude.Controls.Add(this.cbExcludeModelPoints);
            this.gpExclude.Controls.Add(this.cbExcludeLines);
            this.gpExclude.Controls.Add(this.cbExcludeElementProperties);
            resources.ApplyResources(this.gpExclude, "gpExclude");
            this.gpExclude.Name = "gpExclude";
            this.gpExclude.TabStop = false;
            // 
            // cbExcludeUnselectedElements
            // 
            resources.ApplyResources(this.cbExcludeUnselectedElements, "cbExcludeUnselectedElements");
            this.cbExcludeUnselectedElements.Name = "cbExcludeUnselectedElements";
            this.cbExcludeUnselectedElements.UseVisualStyleBackColor = true;
            // 
            // cbExcludeModelPoints
            // 
            resources.ApplyResources(this.cbExcludeModelPoints, "cbExcludeModelPoints");
            this.cbExcludeModelPoints.Name = "cbExcludeModelPoints";
            this.cbExcludeModelPoints.UseVisualStyleBackColor = true;
            // 
            // cbExcludeLines
            // 
            resources.ApplyResources(this.cbExcludeLines, "cbExcludeLines");
            this.cbExcludeLines.Name = "cbExcludeLines";
            this.cbExcludeLines.UseVisualStyleBackColor = true;
            // 
            // cbExcludeElementProperties
            // 
            resources.ApplyResources(this.cbExcludeElementProperties, "cbExcludeElementProperties");
            this.cbExcludeElementProperties.Name = "cbExcludeElementProperties";
            this.cbExcludeElementProperties.UseVisualStyleBackColor = true;
            // 
            // gpConsolidate
            // 
            this.gpConsolidate.Controls.Add(this.cbConsolidateAssembly);
            this.gpConsolidate.Controls.Add(this.cbConsolidateArrayGroup);
            resources.ApplyResources(this.gpConsolidate, "gpConsolidate");
            this.gpConsolidate.Name = "gpConsolidate";
            this.gpConsolidate.TabStop = false;
            // 
            // cbConsolidateAssembly
            // 
            resources.ApplyResources(this.cbConsolidateAssembly, "cbConsolidateAssembly");
            this.cbConsolidateAssembly.Name = "cbConsolidateAssembly";
            this.cbConsolidateAssembly.UseVisualStyleBackColor = true;
            // 
            // cbConsolidateArrayGroup
            // 
            resources.ApplyResources(this.cbConsolidateArrayGroup, "cbConsolidateArrayGroup");
            this.cbConsolidateArrayGroup.Name = "cbConsolidateArrayGroup";
            this.cbConsolidateArrayGroup.UseVisualStyleBackColor = true;
            // 
            // gp2DViews
            // 
            this.gp2DViews.Controls.Add(this.rb2DViewsAll);
            this.gp2DViews.Controls.Add(this.rb2DViewsOnlySheet);
            this.gp2DViews.Controls.Add(this.rb2DViewsBypass);
            resources.ApplyResources(this.gp2DViews, "gp2DViews");
            this.gp2DViews.Name = "gp2DViews";
            this.gp2DViews.TabStop = false;
            // 
            // rb2DViewsAll
            // 
            resources.ApplyResources(this.rb2DViewsAll, "rb2DViewsAll");
            this.rb2DViewsAll.Name = "rb2DViewsAll";
            this.rb2DViewsAll.TabStop = true;
            this.rb2DViewsAll.UseVisualStyleBackColor = true;
            // 
            // rb2DViewsOnlySheet
            // 
            resources.ApplyResources(this.rb2DViewsOnlySheet, "rb2DViewsOnlySheet");
            this.rb2DViewsOnlySheet.Name = "rb2DViewsOnlySheet";
            this.rb2DViewsOnlySheet.TabStop = true;
            this.rb2DViewsOnlySheet.UseVisualStyleBackColor = true;
            // 
            // rb2DViewsBypass
            // 
            resources.ApplyResources(this.rb2DViewsBypass, "rb2DViewsBypass");
            this.rb2DViewsBypass.Name = "rb2DViewsBypass";
            this.rb2DViewsBypass.TabStop = true;
            this.rb2DViewsBypass.UseVisualStyleBackColor = true;
            // 
            // gpGroupByLevel
            // 
            this.gpGroupByLevel.Controls.Add(this.rbGroupByLevelBoundingBox);
            this.gpGroupByLevel.Controls.Add(this.rbGroupByLevelNavisworks);
            this.gpGroupByLevel.Controls.Add(this.rbGroupByLevelDefault);
            this.gpGroupByLevel.Controls.Add(this.rbGroupByLevelDisable);
            resources.ApplyResources(this.gpGroupByLevel, "gpGroupByLevel");
            this.gpGroupByLevel.Name = "gpGroupByLevel";
            this.gpGroupByLevel.TabStop = false;
            // 
            // rbGroupByLevelBoundingBox
            // 
            resources.ApplyResources(this.rbGroupByLevelBoundingBox, "rbGroupByLevelBoundingBox");
            this.rbGroupByLevelBoundingBox.Name = "rbGroupByLevelBoundingBox";
            this.rbGroupByLevelBoundingBox.TabStop = true;
            this.rbGroupByLevelBoundingBox.UseVisualStyleBackColor = true;
            // 
            // rbGroupByLevelNavisworks
            // 
            resources.ApplyResources(this.rbGroupByLevelNavisworks, "rbGroupByLevelNavisworks");
            this.rbGroupByLevelNavisworks.Name = "rbGroupByLevelNavisworks";
            this.rbGroupByLevelNavisworks.TabStop = true;
            this.rbGroupByLevelNavisworks.UseVisualStyleBackColor = true;
            // 
            // rbGroupByLevelDefault
            // 
            resources.ApplyResources(this.rbGroupByLevelDefault, "rbGroupByLevelDefault");
            this.rbGroupByLevelDefault.Name = "rbGroupByLevelDefault";
            this.rbGroupByLevelDefault.TabStop = true;
            this.rbGroupByLevelDefault.UseVisualStyleBackColor = true;
            // 
            // rbGroupByLevelDisable
            // 
            resources.ApplyResources(this.rbGroupByLevelDisable, "rbGroupByLevelDisable");
            this.rbGroupByLevelDisable.Name = "rbGroupByLevelDisable";
            this.rbGroupByLevelDisable.TabStop = true;
            this.rbGroupByLevelDisable.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            resources.ApplyResources(this.lblOptions, "lblOptions");
            this.lblOptions.Name = "lblOptions";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtTargetPath
            // 
            resources.ApplyResources(this.txtTargetPath, "txtTargetPath");
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.ReadOnly = true;
            // 
            // lblOutputPath
            // 
            resources.ApplyResources(this.lblOutputPath, "lblOutputPath");
            this.lblOutputPath.Name = "lblOutputPath";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLicense
            // 
            resources.ApplyResources(this.btnLicense, "btnLicense");
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // btnResetOptions
            // 
            resources.ApplyResources(this.btnResetOptions, "btnResetOptions");
            this.btnResetOptions.Name = "btnResetOptions";
            this.btnResetOptions.UseVisualStyleBackColor = true;
            this.btnResetOptions.Click += new System.EventHandler(this.btnResetOptions_Click);
            // 
            // FormExportSvfzipXp
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnResetOptions);
            this.Controls.Add(this.btnLicense);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpContainer);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportSvfzipXp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExportSvfzip_FormClosing);
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.Shown += new System.EventHandler(this.FormExportSvfzip_Shown);
            this.gpContainer.ResumeLayout(false);
            this.gpContainer.PerformLayout();
            this.gpGeneral.ResumeLayout(false);
            this.gpGeneral.PerformLayout();
            this.gpGenerate.ResumeLayout(false);
            this.gpGenerate.PerformLayout();
            this.gpInclude.ResumeLayout(false);
            this.gpInclude.PerformLayout();
            this.gpExclude.ResumeLayout(false);
            this.gpExclude.PerformLayout();
            this.gpConsolidate.ResumeLayout(false);
            this.gpConsolidate.PerformLayout();
            this.gp2DViews.ResumeLayout(false);
            this.gp2DViews.PerformLayout();
            this.gpGroupByLevel.ResumeLayout(false);
            this.gpGroupByLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gpContainer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cbVisualStyle;
        private System.Windows.Forms.Label lblVisualStyle;
        private System.Windows.Forms.ComboBox cbLevelOfDetail;
        private System.Windows.Forms.Label lblLevelOfDetail;
        private System.Windows.Forms.GroupBox gp2DViews;
        private System.Windows.Forms.RadioButton rb2DViewsAll;
        private System.Windows.Forms.RadioButton rb2DViewsOnlySheet;
        private System.Windows.Forms.RadioButton rb2DViewsBypass;
        private System.Windows.Forms.GroupBox gpGroupByLevel;
        private System.Windows.Forms.RadioButton rbGroupByLevelBoundingBox;
        private System.Windows.Forms.RadioButton rbGroupByLevelNavisworks;
        private System.Windows.Forms.RadioButton rbGroupByLevelDefault;
        private System.Windows.Forms.RadioButton rbGroupByLevelDisable;
        private System.Windows.Forms.GroupBox gpGeneral;
        private System.Windows.Forms.GroupBox gpGenerate;
        private System.Windows.Forms.CheckBox cbGeneratePropDbSqlite;
        private System.Windows.Forms.CheckBox cbGeneratePropDbJson;
        private System.Windows.Forms.CheckBox cbGenerateThumbnail;
        private System.Windows.Forms.GroupBox gpInclude;
        private System.Windows.Forms.CheckBox cbIncludeRooms;
        private System.Windows.Forms.CheckBox cbIncludeGrids;
        private System.Windows.Forms.GroupBox gpExclude;
        private System.Windows.Forms.CheckBox cbExcludeUnselectedElements;
        private System.Windows.Forms.CheckBox cbExcludeModelPoints;
        private System.Windows.Forms.CheckBox cbExcludeLines;
        private System.Windows.Forms.CheckBox cbExcludeElementProperties;
        private System.Windows.Forms.GroupBox gpConsolidate;
        private System.Windows.Forms.CheckBox cbConsolidateAssembly;
        private System.Windows.Forms.CheckBox cbConsolidateArrayGroup;
        private System.Windows.Forms.Button btnResetOptions;
        private System.Windows.Forms.CheckBox cbUseCurrentViewport;
    }
}