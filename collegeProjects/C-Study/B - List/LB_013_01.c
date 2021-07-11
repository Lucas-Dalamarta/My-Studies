int main()
{
	int a , b , c , d;
	printf("Digite A :\n");
	scanf("%d",&a);
	printf("Digite B :\n");
	scanf("%d",&b);
	c=a%b;d=b%a;
	
	if(c==0)
	{
		printf("A multiplo de B\n");
	}
	else
	{
		printf("A Nao multiplo de B\n");
	}
	if(d==0)
	{		
		printf("B e multiplo de A\n");
	}
	else
	{
		printf("B nao e multiplo de A\n");
	}	
	return 0;
}
