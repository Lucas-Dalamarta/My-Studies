int main()
{
	int id  ;
	char s ;
	printf("Digite a idade \n");scanf("%d",&id);getchar();
	printf("Digite o sexo\n");s=getchar();
	
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
		else
		{
			if(s=='h')
			{
				printf("HOMEM\n");
			}
			else
			{
				printf("MULHER\n");
			}
		}
	}
	
	return 0;
}
