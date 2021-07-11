int main()
{
	float n ;
	printf("Digite a nota de 0 a 10 :\n");scanf("%f",&n);
	if(n==0)
	{
		printf("Ja era ...\n");
	}
	else
	{
		if(n<5)
		{
			printf("Comece a estudar agora mesmo\n");
		}
		else 
		{
			if(n<7)
			{
				printf("Quase nao deu !\n");	
			}
			else
			{
				if(n<9)
				{
					printf("Esta bom , mas pode melhorar \n");
				}
				else
				{
					printf("Com voce o Brasil esta feito\n");
				}
			}
		}
	}
	return 0;
}
