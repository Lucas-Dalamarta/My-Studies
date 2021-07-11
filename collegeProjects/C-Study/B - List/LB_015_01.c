int main()
{
	float n1 , n2 , n3 , me ;
	
	printf("Digite a nota 1 : \n");
	scanf("%f",&n1);
	printf("Digite a nota 2 : \n");
	scanf("%f",&n2);
	printf("Digite a nota 3 :\n");
	scanf("%f",&n3);
	
	me=(n1+n2+n3)/3;
	
	printf("Media : %.2f\n",me);
	
	if(me>=7)
	{
		printf("APROVADO\n");
	}
	else
	{
		if(me<3)
		{
				printf("REPROVADO\n");
		}
		else
		{
				printf("EXAME\n");
		}
	}
	
	return 0;
}
