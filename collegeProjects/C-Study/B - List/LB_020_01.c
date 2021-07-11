int main()
{
	int id ;
	char s ;
	
	printf("Digite a idade \n");scanf("%d",&id);getchar();
	printf("Digite o sexo{h}-{m}");s=getchar();
	
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
			
				case 'h' : printf("HOMEM\n");break;
				case 'm' : printf("MULHER\n");break;
				default : printf("SEXO INVALIDO\n");break;
			}
		}
	}
	
	return 0;
}
