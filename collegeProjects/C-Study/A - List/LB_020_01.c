int main()
{
	int id , s ;
	
	printf("Digite a idade \n");scanf("%d",&id);
	printf("Digite o sexo \n{1}MASCULINO\n{2}FEMININO\n");scanf("%d",&s);
	
	if(id<12)
	{
		printf("CRIANCA\n");
	}
	else
	{
		if(id<=18)
		{
			printf("ADOLESCENTE\n");
		}
		if(id>18)
		{
			switch(s)
			{
				case 1 : printf("HOMEM\n");break;
				case 2 : printf("MULHER\n");break;
				default : printf("SEXO INVALIDO\n");break;
			}
		}
	}
	
	return 0;
}
