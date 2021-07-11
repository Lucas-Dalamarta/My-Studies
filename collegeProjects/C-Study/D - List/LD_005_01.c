int main()
{
	int i , mah=0 , mam=0 , mph=0 , mpm=0 , mih=0 , mim=0 , qtd=0 , th=0 , tm=0 ;
	int id[qtd];
	float alt[qtd] , pes[qtd]; 
	char sex;
	
	printf("Informe o total de jogadores no time:\n");scanf("%d",&qtd);getchar();
	for(i=0;i<qtd;i++){
		printf("Digite o sexo [m]-[f]:\n");scanf("%c",&sex);
		switch(sex){
			case 'm':{th++;
				printf("Digite a idade :\n");scanf("%d",&id[i]);mih+=id[i];
				printf("Digite a altura :\n");scanf("%f",&alt[i]);mah+=alt[i];
				printf("Digite o peso :\n");scanf("%f",&pes[i]);mph+=pes[i];
			break;}
			case 'f':{tm++;
				printf("Digite a idade :\n");scanf("%d",&id[i]);mim+=id[i];
				printf("Digite a altura :\n");scanf("%f",&alt[i]);mam+=alt[i];
				printf("Digite o peso :\n");scanf("%f",&pes[i]);mpm+=pes[i];				
			break;}
		}
		getchar();
	}
	printf("\tMASCULINO : %d\n",th);
	printf("Media de idade : %d\n",mih/th);
	printf("Media de altura: %d\n",mah/th);
	printf("Media de peso : %d\n",mph/th);
	printf("\tFEMININO : %d\n",tm);
	printf("Media de idade : %d\n",mim/tm);
	printf("Media de altura: %d\n",mam/tm);
	printf("Media de peso : %d\n",mpm/tm);
	system("pause");
}
