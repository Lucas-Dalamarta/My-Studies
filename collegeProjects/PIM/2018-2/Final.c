	#include	"Comps.c"	//	Bibliotecas + Funções gráficas + Funções organizadoras	

	//--|--|--|--|--|--|--|--|--|
	//	Variaveis globais
	//--|--|--|--|--|--|--|--|--|
	
	int		glb_language;
	char	logged_user[12];
	int 	g		=	1; 
	int 	user_access	=	0;
	int 	saida;
	
	//--|--|--|--|--|--|--|--|--|
	FILE *newfile;
	FILE *imoveis;
	FILE *usuarios;
	FILE *clientes;	//	Ponteiros para os arquivos a serem usados
	
typedef	struct{ 	// 	Struct imovel , Usada no FunCad
	char	endereco[40];
	char 	sub[120];
	int 	cod;
	int 	categoria;
	int		dorm;
	int	 	bnh;
	int 	vaga;
	float	area;
	float	preco;

}	imovel;

typedef	struct{	 	//	Struct cliente , Usada no FunCad
	char	nome[128];
	char 	endereco[80];
	char 	email[40];
	char 	genero;
	char 	telefone[20];
	char 	user_access;
	char 	cpf[20];

}	cliente;

int f_Login(){		//	Funcao f_Login , será usada no MAIN
	
	int 	cod; 
	int		i=0;
	int		vl; 
	int		vp;
	int		pos = 0;
	char	t;
	char	b[12];
	char 	l[12];
	char	pass[12];
	
	printf("\tf_Login : ");
	gets(logged_user);

	if(glb_language==1)	printf("\tSenha : ");
	if(glb_language==2)	printf("\tPassword :");
	
	do{
		t = getch();
		
		if( isprint (t) ){
			b[ pos++ ] = t;
			printf("%c",'*');
		}
		else if( t == 8 && pos ){
			b[ pos -- ];
			printf("%s","\b \b");
		}	
	}while( t != 13 );
	
	usuarios = fopen("Usuarios.txt","r+");
		
	while(!feof(usuarios)){		
		fscanf(usuarios,"%d %s %s\n",&cod,l,pass);	
		vl=strcmp(logged_user,l);		//	Verificação de f_Login
		vp=strcmp(b,pass);		//	Verificação de Senha
	
		if(cod == 1 )
			if(vl == 0 && vp == 0 )	{		
					fclose(usuarios);	return 1;	}	// Retorna 1 , caso alogged_userum f_Login && senha confira
		if(cod == 2 )
			if(vl == 0 && vp == 0 )	{
			 		fclose(usuarios);	return 2; 	}	// Retorna 2 , caso alogged_userum f_Login && senha confira		
	i++;	
	}	
	if( vl != 0 && vp != 0 ){
		return 0;
	}	
}

void	f_print_user(){
	switch(glb_language){
		case	1:{
			return	printf("Logado como :\t%s",logged_user);
		}
		case	2:{
			return	printf("Logged as   :\t%s",logged_user);
		}
	}
}

int 	next (int opt){			//	Funcao Continuar
	
	int	r;
	
	switch(opt){
		case	1:{
			switch(glb_language){
				case	1:{
					printf("\n\t\t [1]-Novo Cadastro\t[0]-Sair ");
				break;
				}
				case	2:{
					printf("\n\t\t [1]-New Registration\t[0]-Exit ");
				break;
				}
			}
		break;
		}
		case	2:{
			switch(glb_language){
				case	1:{
					printf("\n\t\t [1]-Nova Lista\t[0]-Sair ");
				break;
				}
				case	2:{
					printf("\n\t\t [1]-New List\t[0]-Exit ");
				break;
				}
			}
		break;
		}
		case	3:{
			switch(glb_language){
				case	1:{
					printf("\n\t\t [1]-Nova Exclusão\t[0]-Sair ");
				break;
				}
				case	2:{
					printf("\n\t\t [1]-New Deletion\t[0]-Exit ");
				break;
				}
			}
		break;
		}
		case	4:{
			switch(glb_language){
				case	1:{
					printf("\n\t\t [1]-Nova Simulação\t[0]-Sair ");
				break;
				}
				case	2:{
					printf("\n\t\t [1]-New Simulation\t[0]-Exit ");
				break;
				}
			}
		break;
		}
	}
	scanf("%d",&r);
	
	f(5,1);
	f(3,1);

	return r;
}

void	f_Intro(){			//	Funcao f_Introdução 
	
	setlocale(LC_ALL,"Portuguese");	//Irá definir o idioma dos caracteres
	
	f(1,1);

	printf("\tEscolha o idioma // Choose glb_languageuage : ");
	printf("\t[1]-Português-BR\t[2]-English\t[0]-Sair // Quit\t");	
	printf("\t\t\tEscolha : ");
	scanf("%d",&glb_language);	
	
	if(glb_language != 1 || glb_language != 2 || glb_language != 0 )	system("cls");	//f_Intro();
	
	f(1,1);
	
	switch(glb_language){
		case	0:{
			f(1,0);
			printf("\t\tPrograma Finalizado\t\t Application Ended");
			exit(1);
		}
		case	1:{
			printf("\n\tBem vindo a imobiliaria DESTINO :\n\n");
		break;
		}
		case	2:{
			printf("\n\tWelcome to DESTINO real estate  :\n\n");
		break;
		}
	}
	f(2,1);
	f(3,1);
}

char PutPlus(char* NoPlus){		//	Funcao que coloca o + no lugar do Espaço , deve-se informar a var do tipo char
	int f , size;

	for (f=0;f<strlen(NoPlus);f++)
	{
		if (NoPlus[f]==' ')
		{
			NoPlus[f]='+';
		}
	}
}
char MissPlus(char* WtPlus){	//	Funcao que coloca o Espaço no lugar do + , deve-se informar a var do tipo char
	int z;
	for (z=0;z<strlen(WtPlus);z++)
	{
		if (WtPlus[z]=='+')
		{
			WtPlus[z]=' ';
		}
	}
}

void FunFin(){
	float 	juros=0;
	int 	o_func=0;		//	Opcao de saida da funcao
	int 	op=0;		//	Opcao de calculo
	int 	v_numpar=0;	//	Numero de parcelas
	float	v_original=0;
	float	v_entrada=0;
	float 	v_vpar=0;
	
	switch (glb_language){
		case	1:{
			printf("\t\tSIMULAR FINANCIAMENTO : ");
			printf("\tDigite o valor do imovel : ");					scanf("%f",&v_original);
			printf("\tDigite o valor de entrada : ");					scanf("%f",&v_entrada);
			printf("\tDigite qual informação será entrada :\n");
			printf("\t[1]-Numero de parcelas\t[2]-Valor das parcelas");	scanf("%d",&op);
			printf("\tDigite o percentual de juros :\t");				scanf("%f",&juros);
		break;
		}
		case	2:{
			printf("\t\tFINANCING SIMULATION  : ");
			printf("\tEnter property's value: ");						scanf("%f",&v_original);	
			printf("\tEnter down payment value : ");					scanf("%f",&v_entrada);
			printf("\tChoose what info will be used :\n");
			printf("\t[1]-Parcel number\t[2]-Parcel value");			scanf("%d",&op);
			printf("\tInterest perceentual :\t");						scanf("%f",&juros);
		break;
		}
	}
	
	f(2,1);
	juros=juros/10;
	
	switch(op){
		case 1: {
			switch(glb_language){
				case	1:{
					printf("\tDigite o numero de parcelas :\t");
					scanf("%d",&v_numpar);
					v_vpar	=	((v_original-v_entrada)*juros)/v_numpar;
					printf("\tValor da parcela : %.2f",v_vpar);
				break;
				}
				case	2:{
					printf("\tInform number of parcels :\t");
					scanf("%d",&v_numpar);
					v_vpar	=	((v_original-v_entrada)*juros)/v_numpar;
					printf("\tParcel Value: %.2f",v_vpar);
				break;
				}
			}
		break;
		}
		case 2:	{
			switch(glb_language){
				case	1:{
					printf("\tDigite o valor das parcelas :\t");
					scanf("%f",&v_vpar);
					v_numpar=((v_original-v_entrada)*juros)/v_vpar;
					printf("\tTotal de parcelas = %f",v_numpar);
				break;
				}
				case	2:{
					printf("\tInform parcel value :\t");
					scanf("%f",&v_vpar);
					v_numpar=((v_original-v_entrada)*juros)/v_vpar;
					printf("\tNumber of parcels = %f",v_numpar);
				break;
				}
			}
		}
	}
	
	o_func	=	next(4);
		
	switch(o_func){
		case	0:{
			switch(user_access){
				case	1:{
					f_Admin();
				break;
				}
				case	2:{
					f_User();
				break;
				}
			}
		break;
		}
		case	1:{
			FunFin();
		break;
		}
	}
}	
void f_Excluir(){		//	Funcao Exclusao
	
	char exl[40];
	int choice=0;
	int cod=0;
	char logged_usern[12];
	char buff[12];
	
	imovel imo;
	cliente cli;
	
	switch(glb_language){
		case	1:{
			printf("\t\t EXCLUSÕES	:");
			f_print_user();
			printf("\n\t[1]-Imóvel\t[2]-Cliente\n");
			printf("\t\t[3]-Usuário (APENAS ADMNISTRADOR)\n\t\t Escolha :");
			f(2,1);
		break;
		}
		case	2:{
			printf("\t\t EXCLUSIONS	:");
			printf("\n\t[1]-Property\t[2]-Client\n");
			printf("\t\t[3]-User (APENAS ADMNISTRADOR)\n\t\t Choice :");
			f(2,1);
		break;
		}
	}
	scanf("%d",&choice);
	getchar();
	
	switch(choice){
		case 1:{
			switch(glb_language){
				case	1:{
					printf("\n\t Informe o endereço a ser removido :\t");
				break;
				}
				case	2:{
					printf("\n\t Inform the address to be removed  :\t");
				break;
				}
			}
			scanf("%s",exl);
			PutPlus(exl);
			
		imoveis = fopen("Imoveis.txt","r+");
		newfile = fopen("N_Imoveis.txt","w");
		
		while(!feof(imoveis)){
			fscanf(imoveis,"%d",&imo.categoria);
			fscanf(imoveis," %s",imo.endereco);
			fscanf(imoveis," %d",&imo.dorm);
			fscanf(imoveis," %d",&imo.bnh);
			fscanf(imoveis," %.2f",&imo.area); 
			fscanf(imoveis," %d",&imo.vaga);
			fscanf(imoveis," %.2f",&imo.preco);
			fscanf(imoveis," %s\n",imo.sub);
			
			if(strcmp (exl , imo.endereco)!=0){
				fprintf(newfile,"%d",imo.categoria);
				fprintf(newfile," %s",imo.endereco);
				fprintf(newfile," %d",imo.dorm);
				fprintf(newfile," %d",imo.bnh);
				fprintf(newfile," %.2f",imo.area); 
				fprintf(newfile," %d",imo.vaga);
				fprintf(newfile," %.2f",imo.preco);
				fprintf(newfile," %s\n",imo.sub);
			}
		}
		
		fclose(imoveis);
		fclose(newfile);
		
		system("del Imoveis.txt");
		system("rename N_Imoveis.txt Imoveis.txt");
		break;
		}
		
		case 2:{	//	Funcionando	//	Cliente
			switch (glb_language){
				case	1:{
					printf("\n\t Informe o nome do cliente a ser removido 	:\t");
				}
				case	2:{
					printf("\n\t Inform the client's name to be removed 	:\t");
				}
				
			}
			gets(exl);
			PutPlus(exl);
			
			printf("%s \n",exl);
			
			clientes =	fopen("Clientes.txt","r+");
			newfile	 =	fopen("N_Clientes.txt","w");
			
			while(!feof(clientes)){
		
				fscanf(clientes,"%s",cli.telefone);
				fscanf(clientes," %s",cli.cpf);
				fscanf(clientes," %s",cli.nome);
				fscanf(clientes," %s",cli.endereco);
				fscanf(clientes," %s",cli.email);
				fscanf(clientes," %c",&cli.genero);
				fscanf(clientes," %c\n",&cli.user_access);
				
				if(strcmp(exl , cli.nome)!=0){
					fprintf(newfile,"%s",cli.telefone);
					fprintf(newfile," %s",cli.cpf);
					fprintf(newfile," %s",cli.nome);
					fprintf(newfile," %s",cli.endereco);
					fprintf(newfile," %s",cli.email);
					fprintf(newfile," %c",cli.genero);
					fprintf(newfile," %c\n",cli.user_access);
				}
			}
		fclose(clientes);
		fclose(newfile);
		
		system("del Clientes.txt");
		system("rename N_Clientes.txt Clientes.txt");
		break;
		}
		case 3:{	//	Funcionando	//	Usuario
			switch(user_access){
				case	1:{
					if(glb_language==1){	printf("\n\t Informe o usuario a ser removido 	:\t");	}
					if(glb_language==2){	printf("\n\t Inform the user to be removed		:\t");	}
			
					scanf("%s",exl);
				
					usuarios =	fopen("Usuarios.txt","r+");
					newfile	 =	fopen("N_Usuarios.txt","w");
					
					while(!feof(usuarios))	{
						
						fscanf(usuarios,"%d %s %s\n",&cod,logged_usern,buff);
						
							if(strcmp(logged_usern,	exl)!=0){
								fprintf(newfile,"%d %s %s\n",cod,logged_usern,buff);
							}
					}
					
					fclose(usuarios);
					fclose(newfile);
				
					system("del Usuarios.txt");
					system("rename N_Usuarios.txt Usuarios.txt");
				break;
				}
				case	2:{
					switch(glb_language){
						case	1:{
							printf("\n\tERRO : O usuário não pode realizar esta ação\n\t\tEscolha outro tipo de exclusão");
							break;
						}
						case	2:{
							printf("\n\tERROR : User isn't allowed to perform this action\n\t\tChoose another deletion type");
							break;
						}
					}
				break;
				}
			}
		break;
		}			
			case 0:{
				if(user_access==1)	f_Admin();
				if(user_access==2)	f_User();
					break;
			}
	}
	saida=next(3);
	
	if(saida==1){
		f(5,1);	f_Excluir();
	}
	else
		f(6,1);
}
void FunLis(){		//	Funcao Listagem	//	Funcionando
	cliente g;
	imovel d;
	int choice=0;
	int cod=0;
	char logged_usern[12];
	char buff[12];

	if(glb_language==1)	printf("\t\t LISTAGENS :\n");
	if(glb_language==2)	printf("\t\t LISTS     :\n");	
	
	f(2,1);
	
	if(glb_language==1){
		printf("\tEscolha o tipo de lista :\n");	
		printf("\n\t[1]-Imóvel\t[2]-Cliente");
		printf("\n\t[3]-Usuário =(APENAS ADMNISTRADOR)=\n\t\tEscolha :");
	}
	if(glb_language==2){
		printf("\tSelect lists user_access :\n");	
		printf("\n\t[1]-Property\t[2]-Client");
		printf("\n\t[3]-User =(ADMIN ONLY)=\n\t\tChoice :");		
	}
		scanf("%d",&choice);	getchar();
	
	f(1,1);
	f(5,1);
	
	switch(choice){
	
	case 1: {	//	Funcionando		//	Imoveis
	
		imoveis = fopen("Imoveis.txt","r+");
			while(!feof(imoveis)){
				fscanf(imoveis,"%d",&d.categoria);
				fscanf(imoveis," %s",d.endereco);
				fscanf(imoveis," %d",&d.dorm);
				fscanf(imoveis," %d",&d.bnh);
				fscanf(imoveis," %.2f",&d.area); 
				fscanf(imoveis," %d",&d.vaga);
				fscanf(imoveis," %.2f",&d.preco);
				fscanf(imoveis," %s\n",d.sub);
				
				MissPlus(d.endereco);
				MissPlus(d.sub);
				
				if(glb_language==1){
					
					printf("\n\tCategoria : ");
					
				switch(d.categoria){
					case 1 :	printf("\tTerreno\n");		break;
					case 2 :	printf("\tCasa \n");		break;
					case 3 :	printf("\tApartamento \n");	break;
					case 4 :	printf("\tChacara \n");		break;
					case 5 :	printf("\tGalpão \n");		break;
					}
					
					printf("\tEndereço:\t %s",d.endereco);
					printf("\tDormitórios:\t %d",d.dorm);
					printf("\n\tBanheiros:\t %d",d.bnh);		
					printf("\n\tArea:\t %.2f",d.area);
					printf("\n\tVagas para estacionamento :\t %d",d.vaga);
					printf("\tPreço:\t %.2f",d.preco);
					printf("\n\tDescrição :\t %s",d.sub);
			
				}
				
				if(glb_language==2){
					
					printf("\n\tCategory : ");
					
				switch(d.categoria){
					case 1 :	printf("\tLand\n");			break;
					case 2 :	printf("\tHouse \n");		break;
					case 3 :	printf("\tApartment \n");	break;
					case 4 :	printf("\tFarm \n");		break;
					case 5 :	printf("\tShed \n");		break;
					}
					
					printf("\tAdress:\t %s",d.endereco);
					printf("\tDorms:\t %d",d.dorm);
					printf("\n\tBathrooms:\t %d",d.bnh);		
					printf("\n\tArea:\t %.2f",d.area);
					printf("\n\tParking slots :\t %d",d.vaga);
					printf("\tValue:\t %.2f",d.preco);
					printf("\n\tDescription :\t %s",d.sub);
			
				}
				
			}	
		fclose(imoveis);
		break;
}
	case 2:	{	//	Funcionando		//	Clientes
		
			clientes = fopen("Clientes.txt","r+");
			
			while(!feof(clientes)){
			
				fscanf(clientes,"%s",g.telefone);
				fscanf(clientes," %s",g.cpf);
				fscanf(clientes," %s",g.nome);
				fscanf(clientes," %s",g.endereco);
				fscanf(clientes," %s",g.email);
				fscanf(clientes," %c",&g.genero);
				fscanf(clientes," %c\n",&g.user_access);
				
				
				MissPlus(g.endereco);
				MissPlus(g.nome);
		
			if(glb_language==1){

			
				printf("\n\tNome do cliente :\t %s",g.nome);
				printf("\n\tTelefone :\t %s ",g.telefone);
				printf("\n\tE-mail :\t %s",g.email);			
									
			if(g.genero=='m'||g.genero=='M')	{	printf("\n\tSexo : Masculino ");	}
			if(g.genero=='f'||g.genero=='F')	{	printf("\n\tsexo : Feminino  ");	}					
						
				printf("\n\tEndereço :\t %s",g.endereco);											
			}
		
			if(glb_language==2){
				
				printf("\n\tClient's :\t %s",g.nome);
				printf("\n\tPhone Number :\t %s ",g.telefone);
				printf("\n\tE-mail :\t %s",g.email);			
									
			if(g.genero=='m'||g.genero=='M')	{	printf("\n\tGender :\t Male		");	}
			if(g.genero=='f'||g.genero=='F')	{	printf("\n\tGender :\t Female	");	}					
						
				printf("\n\tAddress :\t %s",g.endereco);
			}
			
			if(g.user_access=='p'||g.user_access=='P')	{	printf("\n\tCPF   :\t\t %s",g.cpf);	}
			if(g.user_access=='j'||g.user_access=='J')	{	printf("\n\tCNPJ  :\t\t %s",g.cpf);	}
			
			printf("\n--------------------------------------------\n");	
		}
			fclose(clientes);
	}	break;
	case 3:	{	//	Funcionando		//	Usuarios
		
		if(glb_language==1)		printf("\n\tListagem De Usuarios");
		
		if(glb_language==2)		printf("\n\tUser Lists");
	
	if(user_access==1){
	
		usuarios = fopen("Usuarios.txt","r+");	
			
			while(!feof(usuarios))	{
				
				fscanf(usuarios,"%d %s %s\n",&cod,logged_usern,buff);
			
			if(glb_language==1){
				printf("\n\tCodigo : ( %d )",cod);
				printf("\tf_Login :    ( %s )",logged_usern);
				printf("\tSenha :    ( %s )",buff);
			}
			if(glb_language==2){
				printf("\n\tCode :    ( %d )",cod);
				printf("\tf_Login :    ( %s )",logged_usern);
				printf("\tPassword : ( %s )",buff);
			}
		}
		fclose(usuarios);
	} 
	if(user_access==2){	
				if(glb_language==1)	printf("\n\tERRO : O usuario nao pode realizar esta acao\n\t\tEscolha outro tipo de cadastro");
				if(glb_language==2)	printf("\n\tERROR : User isn't allow to perform this action\n\t\tChoose another entry user_access");
			}
		break;
		}
	}
	saida=next(2);
	
	if(saida==1){
		FunLis();
	}
	if(saida==0){
		if(user_access==1){
			f_Admin();
		}
		if(user_access==2){
			f_User();
	 }
	}
}
void FunCad(){		//	Funcao Cadastro	//	Funcionando
	
	int z;
	int c;
	int op=0;
	int pst=0;
	int p;
	int r=0;
	int cod=0;
	char dgt;
	char buffer[12];
	char f_Login[12];
	char entry[20];	
	
	imovel i;	
	cliente j ;
	
	if(glb_language==1)	printf("\t\t\t\tNOVO CADASTRO  	:");
	if(glb_language==2)	printf("\t\t\t\tNEW  ENTRY 		:");	
	
	f(0,1);
	f(1,1);
	
	if(glb_language==1){
		printf("\tEscolha o tipo de cadastro :");	f(0,1);	f(2,1);	
		printf("\n\t[1]-Imovel\t[2]-Cliente");
		printf("\n\t[3]-Usuario =(APENAS ADMNISTRADOR)=\n\t\tEscolha :");
	}
	if(glb_language==2){
		printf("\tSelect entry user_access :");	f(0,1);	f(2,1);
		printf("\n\t[1]-Property\t[2]-Client");
		printf("\n\t[3]-User =(ADMIN ONLY)=\n\t\tChoice :");		
	}
		scanf("%d",&op);	getchar();
	
	f(5,1);
	
	f(2,1);	
	
	switch(op){
		case 1:{		//	Imovel		//	Funcionando
		if(glb_language==1){
			printf("\tCategoria :\n\n");
			printf("\t[1]-Terreno");
			printf("\t[2]-Casa \n");
			printf("\t[3]-Apartamento ");
			printf("\t[4]-Chacara \n");
			printf("\t[5]-Galpao \t");						scanf("%d",&i.categoria);		getchar();
		
			printf("\n\tEndereco:\t" );						gets(i.endereco);
			printf("\tDormitorios:\t");						scanf("%d",&i.dorm);	getchar();
			printf("\n\tBanheiros:\t");						scanf("%d",&i.bnh);		getchar();
			printf("\n\tArea:\t");							scanf("%f",&i.area);	getchar();
			printf("\n\tVagas para estacionamento :\t");	scanf("%d",&i.vaga);	getchar(); 
			printf("\tPreco:\t");							scanf("%f",&i.preco);
			printf("\n\tDescricao :\t");					gets(i.sub);
		}
		if(glb_language==2){
			printf("\tCategory:\n\n");
			printf("\t[1]-Land");
			printf("\t[2]-House\n");
			printf("\t[3]-Apartment");
			printf("\t[4]-Farm\n");
			printf("\t[5]-Shed \t");							scanf("%d",&i.categoria);		getchar();
			
		
			printf("\n\tAdress:\t" );						gets(i.endereco);
			printf("\tDorms:\t");							scanf("%d",&i.dorm);	getchar();
			printf("\n\tBathrooms:\t");						scanf("%d",&i.bnh);		getchar();
			printf("\n\tArea:\t");							scanf("%f",&i.area);	getchar();
			printf("\n\tParking slots :\t");				scanf("%d",&i.vaga);	getchar(); 
			printf("\n\tValue :\t");						scanf("%f",&i.preco);	getchar();
			printf("\n\tDescription :\t");					gets(i.sub);
	 }

		PutPlus(i.sub);
		PutPlus(i.endereco);
		
		imoveis = fopen("Imoveis.txt","a+");
			fprintf(imoveis,"%d",i.categoria);
			fprintf(imoveis," %s",i.endereco);
			fprintf(imoveis," %d",i.dorm);
			fprintf(imoveis," %d",i.bnh);
			fprintf(imoveis," %.2f",i.area); 
			fprintf(imoveis," %d",i.vaga);
			fprintf(imoveis," %.2f",i.preco);
			fprintf(imoveis," %s\n",i.sub);
		fclose(imoveis);
		
			if(glb_language==1)	printf("\n\t Imovel cadastrado com sucesso !\n");
			if(glb_language==2)	printf("\n\t Property entry successfull !\n");
			
			break;
	}
		case 2:{		//	Cliente		//	Funcionando
			if(glb_language==1){
				
				printf("\n\tInforme o nome do cliente :\t");							gets(j.nome);
				printf("\n\tInforme o telefone :\t");									scanf("%s",j.telefone);	getchar();
				printf("\n\tInforme o e-mail :\t");										scanf("%s",j.email);	getchar();				
				printf("\n\tInforme o genero :\t[M]-Masculino\t[F]-Feminino :\t");		j.genero=getchar();	getchar();
				printf("\n\tInforme o endereco :\t");									gets(j.endereco);
				printf("\n\tInforme :\t[1]-Pessoa Fisica\t[2]-Pessoa Juridica :\t");	scanf("%c",&j.user_access);
				
				if(j.user_access=='p'||j.user_access=='P')	{	printf("\n\tDigite o  CPF  : ");	}
				if(j.user_access=='j'||j.user_access=='J')	{	printf("\n\tDigite o CNPJ  : ");	}					
			}
		
			if(glb_language==2){
				
				printf("\n\tEnter Client's name :\t");								gets(j.nome);
				printf("\n\tEnter phone number :\t");								scanf("%f",&j.telefone);	getchar();
				printf("\n\tEnter e-mail :\t");										scanf("%s",j.email);	getchar();				
				printf("\n\tEnter gender :\t[M]-Male\t[F]-Female :\t");				j.genero=getchar();	getchar();
				printf("\n\tEnter address :\t");									gets(j.endereco);
				printf("\n\tEnter :\t[P]-Private Person\t[J]-Legal Entity :\t");	scanf("%c",&j.user_access);
				
				if(j.user_access=='p'||j.user_access=='P')	{	printf("\n\tEnter CPF  : ");	}
				if(j.user_access=='j'||j.user_access=='J')	{	printf("\n\tEnter CNPJ : ");	}
				
				scanf("%s",j.cpf);		
				}
			
			PutPlus(j.nome);
			PutPlus(j.endereco);

			clientes = fopen("Clientes.txt","a+");
				
				fprintf(clientes,"%s",j.telefone); 
				fprintf(clientes," %s",j.cpf);
				fprintf(clientes," %s",j.nome);
				fprintf(clientes," %s",j.endereco);
				fprintf(clientes," %s",j.email);
				fprintf(clientes," %c",j.genero);
				fprintf(clientes," %c\n",j.user_access);
				
			fclose(clientes);
			
					
			if(glb_language==1)	printf("\n\t Cliente cadastrado com sucesso !\n");
			if(glb_language==2)	printf("\n\t Client entry successfull !\n");
	
		break;
	}
		case 3:{		//	Usuario	//	Funciaonado
	
		if(user_access==1){	//	Só entra se o log for admin	
		
		printf("\n\tDigite o f_Login :");	gets(f_Login);
		
			if(glb_language==1)	printf("\n\tSenha : ");
			if(glb_language==2)	printf("\n\tPassword: ");
		
		do{
			dgt = getch();
				
			if( isprint (dgt) ){
				buffer[ pst++ ] = dgt;
				printf("%c",'*');
			}
			else if( dgt ==8 && pst ){
				buffer[ pst -- ];
				printf("%s","\b \b");
			}	
		}while( dgt != 13 );

		cod=2;
		usuarios = fopen("Usuarios.txt","a+");	
			fprintf(usuarios,"%d %s %s\n",cod,f_Login,buffer);
		fclose(usuarios);
		
		f(4,1);	
		
			if(glb_language==1)	printf("\n\n==== Usuario cadastrado com sucesso !\n");
			if(glb_language==2)	printf("\n\n==== User entry successfull !\n");
		break;
		}
		
		if(user_access==2){	
				if(glb_language==1)	printf("\n\t ERRO : O usuario nao pode realizar esta acao\n\t\tEscolha outro tipo de cadastro");
				if(glb_language==2)	printf("\n\t ERROR : User isn't allow to perform this action\n\t\tChoose another entry user_access");
			}
			break;
	}
		default :{	printf("\n\t\tOpcao Invalida , tente novamente :\n");	FunCad();	break;	
		}
	}	
	saida=next(1);
	
	if(saida==1){	
		
		f(5,1);	
	
		FunCad();
	}
	
	if(saida==0){	
		
		f(5,1);
		
		if(user_access==1)	f_Admin();
		if(user_access==2)	f_User();
		
	}	
}

void f_User(){		//	Funcao Usuario
	int Escolha ;
	
	f(5,1);
	
	f(1,1);
	if(glb_language==1){
		printf("\tLOGADO COMO :\t ( %s )	(Acesso Limitado)\n",logged_user);}
	if(glb_language==2){
		printf("\tLOGGED AS   :\t ( %s ) 	(Limited Access) \n",logged_user);}	
	
	f(2,1);
	
	if(glb_language==1){
		printf("\t[1]-Listar\t[2]-Simular Financiamento");
		printf("\t[3]-Cadastros");								f(0,2);
		printf("\t[0]-Sair Do Programa\t\t");
	}
	if(glb_language==2){
		printf("\t[1]-Lists\t[2]-Financing Simulation");
		printf("\t[3]-New Entry");								f(0,2);
		printf("\t[0]-Quit Application\t\t");
	}
	
	scanf("%d",&Escolha);	f(3,1);
	
	switch(Escolha){
	
		case 1:FunLis();	break;	//	Funcao Pesquisa
		case 2:FunFin();	break;	//	Funcao Financiamentos
		case 3:FunCad();	break;	//	Funcao Cadastro
		case 0:{	printf("\tPrograma Finalizado // Application Ended");	break;	}
				
		default :{	
			if(glb_language==1){	printf("\n\t\tOpcao Invalida , pressione ENTER para limpar a tela");	}
			if(glb_language==2){	printf("\n\t\tInvalid Option , press ENTER to clear screen");	}
		 getche(); system("cls");	f_User();	break;	}
		}
}
void f_Admin(){		//	Funcao Admnistrador
	
	int Escolha ;
	f(5,1);
	f(1,1);
	
	if(glb_language==1)	printf("\tLOGADO COMO :\t ( %s )	(Acesso Total)\n",logged_user);
	if(glb_language==2)	printf("\tLOGGED AS   :\t ( %s ) 	(Full Access) \n",logged_user);	
	f(2,1);
	
	if(glb_language==1){
		printf("\tDigite um numero de acordo com a funcao desejada :\n\n");
		printf("\t[1]-Listar\t\t[2]-Simular Financiamento");	f(0,1);
		printf("\t[3]-Cadastros\t\t[4]-Exclusoes");				f(0,1);
		printf("\n\t[0]-Sair Do Programa\n\n\tEscolha : ");
	}

	if(glb_language==2){
		printf("\tPick a number accordingly to a function :\n\n");
		printf("\t[1]-Lists\t\t[2]-Financing Simulation");		f(0,1);
		printf("\t[3]-New Entry\t\t[4]-Delete Entry");			f(0,1);	
		printf("\t[0]-Quit Application\n\n\tChoice : ");
		}
		
		scanf("%d",&Escolha);	f(1,1);

	switch(Escolha){
		
		case 1:FunLis();	break;	//	Funcao Pesquisa
		case 2:FunFin();	break;	//	Funcao Financiamentos
		case 3:FunCad();	break;	//	Funcao Cadastro
		case 4:f_Excluir();	break;	//	Funcao Exclusao
		case 0:f(6,1);		break;	//	Sair do programa
		default :{
			if(glb_language==1){	printf("\n\t\tOpcao Invalida , pressione ENTER para limpar a tela");	}
			if(glb_language==2){	printf("\n\t\tInvalid Option , press ENTER to clear screen");	}
		getche(); 	system("cls");	f_Admin();	break;	
		}
	}
}

int main(){			//	Funcao MAIN
	
	if(g>=1) {	f_Intro();			//	Conjunto de printf's de f_Introducao a imobiliaria
	
	user_access=f_Login();	}				//	f_Login poderá retornar 1 entre 3 valores , de acordo com os dados informados a ela
	
	f(0,1);							// Numero referente a funcao f e quantidade de vezes que ela sera executada
	do{
	switch(user_access)
	{
		case 0:	{
			f(4,1);
			if(glb_language==1){	printf("\t\tf_Login ou senha incorretos , Tente novamente\n");	}
			if(glb_language==2){	printf("\t\tWrong f_Login/Password , Try Again\n");	}
				user_access=f_Login();
			g=0;	
			main();
			break;	
		}	
		case 1:f_Admin();break; //	Funcao Admin	 					(SIM)
		case 2:f_User();break; //	Funcao Usuario						(SIM)	
	}
	}while(saida!=0);
					
}
