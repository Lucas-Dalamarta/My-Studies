namespace PIM_2019
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_sair = new System.Windows.Forms.Button();
            this.barra_menu = new System.Windows.Forms.MenuStrip();
            this.menu_cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarOficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPostoDeAbastecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeManutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeMultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDePeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeViagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeMotoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abastecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantuençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oSManutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSServiçosPrestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viagensToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeUsuárisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissôesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatarOSuporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatarUmProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_CONTRASTE = new System.Windows.Forms.Button();
            this.bt_frota = new System.Windows.Forms.Button();
            this.bt_motorista = new System.Windows.Forms.Button();
            this.bt_viagens = new System.Windows.Forms.Button();
            this.bt_estoque = new System.Windows.Forms.Button();
            this.bt_rela = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_relogio = new System.Windows.Forms.Label();
            this.lb_versao = new System.Windows.Forms.Label();
            this.lb_suporte = new System.Windows.Forms.Label();
            this.pic_car = new System.Windows.Forms.PictureBox();
            this.barra_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.bt_sair, "bt_sair");
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // barra_menu
            // 
            this.barra_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastros,
            this.estoquesToolStripMenuItem,
            this.frotaToolStripMenuItem,
            this.viagensToolStripMenuItem,
            this.motoristasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            resources.ApplyResources(this.barra_menu, "barra_menu");
            this.barra_menu.Name = "barra_menu";
            // 
            // menu_cadastros
            // 
            this.menu_cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.cadastrarMotoristaToolStripMenuItem,
            this.cadastrarOficinaToolStripMenuItem,
            this.cadastrarOSToolStripMenuItem,
            this.cadastrarPostoDeAbastecimentoToolStripMenuItem,
            this.cadastrarSeguroToolStripMenuItem,
            this.cadastrarUsuárioToolStripMenuItem,
            this.cadastrarVeículoToolStripMenuItem});
            this.menu_cadastros.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.menu_cadastros.Name = "menu_cadastros";
            resources.ApplyResources(this.menu_cadastros, "menu_cadastros");
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            resources.ApplyResources(this.manutençãoToolStripMenuItem, "manutençãoToolStripMenuItem");
            // 
            // cadastrarMotoristaToolStripMenuItem
            // 
            this.cadastrarMotoristaToolStripMenuItem.Name = "cadastrarMotoristaToolStripMenuItem";
            resources.ApplyResources(this.cadastrarMotoristaToolStripMenuItem, "cadastrarMotoristaToolStripMenuItem");
            // 
            // cadastrarOficinaToolStripMenuItem
            // 
            this.cadastrarOficinaToolStripMenuItem.Name = "cadastrarOficinaToolStripMenuItem";
            resources.ApplyResources(this.cadastrarOficinaToolStripMenuItem, "cadastrarOficinaToolStripMenuItem");
            // 
            // cadastrarOSToolStripMenuItem
            // 
            this.cadastrarOSToolStripMenuItem.Name = "cadastrarOSToolStripMenuItem";
            resources.ApplyResources(this.cadastrarOSToolStripMenuItem, "cadastrarOSToolStripMenuItem");
            // 
            // cadastrarPostoDeAbastecimentoToolStripMenuItem
            // 
            this.cadastrarPostoDeAbastecimentoToolStripMenuItem.Name = "cadastrarPostoDeAbastecimentoToolStripMenuItem";
            resources.ApplyResources(this.cadastrarPostoDeAbastecimentoToolStripMenuItem, "cadastrarPostoDeAbastecimentoToolStripMenuItem");
            // 
            // cadastrarSeguroToolStripMenuItem
            // 
            this.cadastrarSeguroToolStripMenuItem.Name = "cadastrarSeguroToolStripMenuItem";
            resources.ApplyResources(this.cadastrarSeguroToolStripMenuItem, "cadastrarSeguroToolStripMenuItem");
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            resources.ApplyResources(this.cadastrarUsuárioToolStripMenuItem, "cadastrarUsuárioToolStripMenuItem");
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            resources.ApplyResources(this.cadastrarVeículoToolStripMenuItem, "cadastrarVeículoToolStripMenuItem");
            // 
            // estoquesToolStripMenuItem
            // 
            this.estoquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peçasToolStripMenuItem1});
            this.estoquesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.estoquesToolStripMenuItem.Name = "estoquesToolStripMenuItem";
            resources.ApplyResources(this.estoquesToolStripMenuItem, "estoquesToolStripMenuItem");
            // 
            // peçasToolStripMenuItem1
            // 
            this.peçasToolStripMenuItem1.Name = "peçasToolStripMenuItem1";
            resources.ApplyResources(this.peçasToolStripMenuItem1, "peçasToolStripMenuItem1");
            // 
            // frotaToolStripMenuItem
            // 
            this.frotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençõesToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.veículosToolStripMenuItem});
            this.frotaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frotaToolStripMenuItem.Name = "frotaToolStripMenuItem";
            resources.ApplyResources(this.frotaToolStripMenuItem, "frotaToolStripMenuItem");
            // 
            // manutençõesToolStripMenuItem
            // 
            this.manutençõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeManutençõesToolStripMenuItem});
            this.manutençõesToolStripMenuItem.Name = "manutençõesToolStripMenuItem";
            resources.ApplyResources(this.manutençõesToolStripMenuItem, "manutençõesToolStripMenuItem");
            // 
            // gerenciamentoDeManutençõesToolStripMenuItem
            // 
            this.gerenciamentoDeManutençõesToolStripMenuItem.Name = "gerenciamentoDeManutençõesToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeManutençõesToolStripMenuItem, "gerenciamentoDeManutençõesToolStripMenuItem");
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeMultasToolStripMenuItem});
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            resources.ApplyResources(this.multasToolStripMenuItem, "multasToolStripMenuItem");
            // 
            // gerenciamentoDeMultasToolStripMenuItem
            // 
            this.gerenciamentoDeMultasToolStripMenuItem.Name = "gerenciamentoDeMultasToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeMultasToolStripMenuItem, "gerenciamentoDeMultasToolStripMenuItem");
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDePeçasToolStripMenuItem});
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            resources.ApplyResources(this.peçasToolStripMenuItem, "peçasToolStripMenuItem");
            // 
            // gerenciamentoDePeçasToolStripMenuItem
            // 
            this.gerenciamentoDePeçasToolStripMenuItem.Name = "gerenciamentoDePeçasToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDePeçasToolStripMenuItem, "gerenciamentoDePeçasToolStripMenuItem");
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeVeículosToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            resources.ApplyResources(this.veículosToolStripMenuItem, "veículosToolStripMenuItem");
            // 
            // gerenciamentoDeVeículosToolStripMenuItem
            // 
            this.gerenciamentoDeVeículosToolStripMenuItem.Name = "gerenciamentoDeVeículosToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeVeículosToolStripMenuItem, "gerenciamentoDeVeículosToolStripMenuItem");
            // 
            // viagensToolStripMenuItem
            // 
            this.viagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeViagensToolStripMenuItem});
            this.viagensToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.viagensToolStripMenuItem.Name = "viagensToolStripMenuItem";
            resources.ApplyResources(this.viagensToolStripMenuItem, "viagensToolStripMenuItem");
            // 
            // gerenciamentoDeViagensToolStripMenuItem
            // 
            this.gerenciamentoDeViagensToolStripMenuItem.Name = "gerenciamentoDeViagensToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeViagensToolStripMenuItem, "gerenciamentoDeViagensToolStripMenuItem");
            // 
            // motoristasToolStripMenuItem
            // 
            this.motoristasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeMotoristasToolStripMenuItem});
            this.motoristasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            resources.ApplyResources(this.motoristasToolStripMenuItem, "motoristasToolStripMenuItem");
            // 
            // gerenciamentoDeMotoristasToolStripMenuItem
            // 
            this.gerenciamentoDeMotoristasToolStripMenuItem.Name = "gerenciamentoDeMotoristasToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeMotoristasToolStripMenuItem, "gerenciamentoDeMotoristasToolStripMenuItem");
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abastecimentosToolStripMenuItem,
            this.mantuençõesToolStripMenuItem,
            this.motoristasToolStripMenuItem1,
            this.movimentoDeEstoqueToolStripMenuItem,
            this.multasToolStripMenuItem1,
            this.oSManutençõesToolStripMenuItem,
            this.oSServiçosPrestadosToolStripMenuItem,
            this.peçasToolStripMenuItem2,
            this.veículosToolStripMenuItem1,
            this.viagensToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // abastecimentosToolStripMenuItem
            // 
            this.abastecimentosToolStripMenuItem.Name = "abastecimentosToolStripMenuItem";
            resources.ApplyResources(this.abastecimentosToolStripMenuItem, "abastecimentosToolStripMenuItem");
            // 
            // mantuençõesToolStripMenuItem
            // 
            this.mantuençõesToolStripMenuItem.Name = "mantuençõesToolStripMenuItem";
            resources.ApplyResources(this.mantuençõesToolStripMenuItem, "mantuençõesToolStripMenuItem");
            // 
            // motoristasToolStripMenuItem1
            // 
            this.motoristasToolStripMenuItem1.Name = "motoristasToolStripMenuItem1";
            resources.ApplyResources(this.motoristasToolStripMenuItem1, "motoristasToolStripMenuItem1");
            // 
            // movimentoDeEstoqueToolStripMenuItem
            // 
            this.movimentoDeEstoqueToolStripMenuItem.Name = "movimentoDeEstoqueToolStripMenuItem";
            resources.ApplyResources(this.movimentoDeEstoqueToolStripMenuItem, "movimentoDeEstoqueToolStripMenuItem");
            // 
            // multasToolStripMenuItem1
            // 
            this.multasToolStripMenuItem1.Name = "multasToolStripMenuItem1";
            resources.ApplyResources(this.multasToolStripMenuItem1, "multasToolStripMenuItem1");
            // 
            // oSManutençõesToolStripMenuItem
            // 
            this.oSManutençõesToolStripMenuItem.Name = "oSManutençõesToolStripMenuItem";
            resources.ApplyResources(this.oSManutençõesToolStripMenuItem, "oSManutençõesToolStripMenuItem");
            // 
            // oSServiçosPrestadosToolStripMenuItem
            // 
            this.oSServiçosPrestadosToolStripMenuItem.Name = "oSServiçosPrestadosToolStripMenuItem";
            resources.ApplyResources(this.oSServiçosPrestadosToolStripMenuItem, "oSServiçosPrestadosToolStripMenuItem");
            // 
            // peçasToolStripMenuItem2
            // 
            this.peçasToolStripMenuItem2.Name = "peçasToolStripMenuItem2";
            resources.ApplyResources(this.peçasToolStripMenuItem2, "peçasToolStripMenuItem2");
            // 
            // veículosToolStripMenuItem1
            // 
            this.veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            resources.ApplyResources(this.veículosToolStripMenuItem1, "veículosToolStripMenuItem1");
            // 
            // viagensToolStripMenuItem1
            // 
            this.viagensToolStripMenuItem1.Name = "viagensToolStripMenuItem1";
            resources.ApplyResources(this.viagensToolStripMenuItem1, "viagensToolStripMenuItem1");
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.cadastrarPerfilToolStripMenuItem,
            this.gerenciamentoDeUsuárisoToolStripMenuItem,
            this.permissôesToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            resources.ApplyResources(this.usuáriosToolStripMenuItem, "usuáriosToolStripMenuItem");
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            resources.ApplyResources(this.alterarSenhaToolStripMenuItem, "alterarSenhaToolStripMenuItem");
            // 
            // cadastrarPerfilToolStripMenuItem
            // 
            this.cadastrarPerfilToolStripMenuItem.Name = "cadastrarPerfilToolStripMenuItem";
            resources.ApplyResources(this.cadastrarPerfilToolStripMenuItem, "cadastrarPerfilToolStripMenuItem");
            // 
            // gerenciamentoDeUsuárisoToolStripMenuItem
            // 
            this.gerenciamentoDeUsuárisoToolStripMenuItem.Name = "gerenciamentoDeUsuárisoToolStripMenuItem";
            resources.ApplyResources(this.gerenciamentoDeUsuárisoToolStripMenuItem, "gerenciamentoDeUsuárisoToolStripMenuItem");
            // 
            // permissôesToolStripMenuItem
            // 
            this.permissôesToolStripMenuItem.Name = "permissôesToolStripMenuItem";
            resources.ApplyResources(this.permissôesToolStripMenuItem, "permissôesToolStripMenuItem");
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatarOSuporteToolStripMenuItem,
            this.manualDoUsuárioToolStripMenuItem,
            this.relatarUmProblemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            // 
            // contatarOSuporteToolStripMenuItem
            // 
            this.contatarOSuporteToolStripMenuItem.Name = "contatarOSuporteToolStripMenuItem";
            resources.ApplyResources(this.contatarOSuporteToolStripMenuItem, "contatarOSuporteToolStripMenuItem");
            // 
            // manualDoUsuárioToolStripMenuItem
            // 
            this.manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
            resources.ApplyResources(this.manualDoUsuárioToolStripMenuItem, "manualDoUsuárioToolStripMenuItem");
            // 
            // relatarUmProblemaToolStripMenuItem
            // 
            this.relatarUmProblemaToolStripMenuItem.Name = "relatarUmProblemaToolStripMenuItem";
            resources.ApplyResources(this.relatarUmProblemaToolStripMenuItem, "relatarUmProblemaToolStripMenuItem");
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoDoSistemaToolStripMenuItem});
            this.sobreToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            // 
            // versãoDoSistemaToolStripMenuItem
            // 
            this.versãoDoSistemaToolStripMenuItem.Name = "versãoDoSistemaToolStripMenuItem";
            resources.ApplyResources(this.versãoDoSistemaToolStripMenuItem, "versãoDoSistemaToolStripMenuItem");
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // bt_CONTRASTE
            // 
            this.bt_CONTRASTE.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_CONTRASTE, "bt_CONTRASTE");
            this.bt_CONTRASTE.Name = "bt_CONTRASTE";
            this.bt_CONTRASTE.UseVisualStyleBackColor = false;
            this.bt_CONTRASTE.Click += new System.EventHandler(this.bt_CONTRASTE_Click);
            // 
            // bt_frota
            // 
            this.bt_frota.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_frota, "bt_frota");
            this.bt_frota.Name = "bt_frota";
            this.bt_frota.UseVisualStyleBackColor = false;
            // 
            // bt_motorista
            // 
            this.bt_motorista.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_motorista, "bt_motorista");
            this.bt_motorista.Name = "bt_motorista";
            this.bt_motorista.UseVisualStyleBackColor = false;
            // 
            // bt_viagens
            // 
            this.bt_viagens.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_viagens, "bt_viagens");
            this.bt_viagens.Name = "bt_viagens";
            this.bt_viagens.UseVisualStyleBackColor = false;
            // 
            // bt_estoque
            // 
            this.bt_estoque.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_estoque, "bt_estoque");
            this.bt_estoque.Name = "bt_estoque";
            this.bt_estoque.UseVisualStyleBackColor = false;
            // 
            // bt_rela
            // 
            this.bt_rela.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.bt_rela, "bt_rela");
            this.bt_rela.Name = "bt_rela";
            this.bt_rela.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_relogio
            // 
            resources.ApplyResources(this.lb_relogio, "lb_relogio");
            this.lb_relogio.Name = "lb_relogio";
            // 
            // lb_versao
            // 
            resources.ApplyResources(this.lb_versao, "lb_versao");
            this.lb_versao.Name = "lb_versao";
            // 
            // lb_suporte
            // 
            resources.ApplyResources(this.lb_suporte, "lb_suporte");
            this.lb_suporte.Name = "lb_suporte";
            // 
            // pic_car
            // 
            this.pic_car.BackColor = System.Drawing.SystemColors.Menu;
            this.pic_car.Image = global::PIM_2019.Properties.Resources.car;
            resources.ApplyResources(this.pic_car, "pic_car");
            this.pic_car.Name = "pic_car";
            this.pic_car.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.pic_car);
            this.Controls.Add(this.lb_suporte);
            this.Controls.Add(this.lb_versao);
            this.Controls.Add(this.lb_relogio);
            this.Controls.Add(this.bt_rela);
            this.Controls.Add(this.bt_estoque);
            this.Controls.Add(this.bt_viagens);
            this.Controls.Add(this.bt_motorista);
            this.Controls.Add(this.bt_frota);
            this.Controls.Add(this.bt_CONTRASTE);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.barra_menu);
            this.MainMenuStrip = this.barra_menu;
            this.Name = "Form1";
            this.barra_menu.ResumeLayout(false);
            this.barra_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.MenuStrip barra_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastros;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPostoDeAbastecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeManutençõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDePeçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeMultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeMotoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeUsuárisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissôesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatarOSuporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatarUmProblemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoDoSistemaToolStripMenuItem;
        private System.Windows.Forms.Button bt_CONTRASTE;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarOficinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeViagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viagensToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abastecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantuençõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oSServiçosPrestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSManutençõesToolStripMenuItem;
        private System.Windows.Forms.Button bt_frota;
        private System.Windows.Forms.Button bt_motorista;
        private System.Windows.Forms.Button bt_viagens;
        private System.Windows.Forms.Button bt_estoque;
        private System.Windows.Forms.Button bt_rela;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_relogio;
        private System.Windows.Forms.Label lb_versao;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lb_suporte;
        private System.Windows.Forms.PictureBox pic_car;
    }
}

