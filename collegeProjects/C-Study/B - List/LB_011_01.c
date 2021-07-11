int main()
{
	int i ;
	
	printf("Informe o indice de poluicao :\n");
	scanf("%d",&i);
	
	if(i<5)
	{
		printf("ERRO\n");
	}
	else if(i<25)
	{
		printf("REGULAR\n");
	}
	else if(i<=30)
	{
		printf("POLUENTE\n");
	}
	else if(i>30)
	{
		printf("ALTAMENTE POLUENTE\n");
	}
	
	return 0;
}
