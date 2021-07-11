int main()
{
	int n ;
	
	printf("Digite um numero :\n");
	scanf("%d",&n);
	
	if(n>=1)
	{
		printf("POSITIVO");
	}
	else if(n<0)
	{
		printf("NEGATIVO");
	}
	else
	{
		printf("ZERO");
	}
	
	return 0;
}
