int main()
{
	int na , nb ;
	
	printf("Digite o numero A :\n");
	scanf("%d",&na);
	printf("Digite o numero B :\n");
	scanf("%d",&nb);
	
	printf("\t  A e igual a 0 ?\n");
		
	if(na==0)
	{
		printf("\t\tV\n");
	}
	else if(na!=0)
	{
		printf("\t\tF\n");
	}
	
	printf("\t  B e menor que 0 ?\n");
	
	if(nb<0)
	{
		printf("\t\tV\n");
	}
	else if(nb!=0)
	{
		printf("\t\tF\n");
	}
	
	printf("\tA ou B sao maiores que 0 ?\n");
	
	if(na>0||nb>0)
	{
		printf("\t\tV\n");
	}
	else
	{
		printf("\t\tF\n");
	}
	
	return 0;
}
