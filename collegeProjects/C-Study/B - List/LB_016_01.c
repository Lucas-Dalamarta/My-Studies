int main()
{
	float n ;
	printf("Digite a nota de 0 a 10 :\n");scanf("%f",&n);
	if(n>0&&n<=1.9)
	{
		printf("E\n");
	}
	else
	{
		if(n<4.9)
		{
			printf("D\n");
		}
		else 
		{
			if(n<6.9)
			{
				printf("C\n");	
			}
			else
			{
				if(n<8.9)
				{
					printf("B\n");
				}
				else
				{
					printf("A\n");
				}
			}
		}
	}
	return 0;
}
