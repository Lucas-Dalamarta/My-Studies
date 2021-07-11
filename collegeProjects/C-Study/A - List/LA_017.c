int main()
{

	int a , b , c ;
	printf("\tDigite o numero A :");
	scanf("%i",&a);
	printf("\n\tDigite o numero B :");
	scanf("%i",&b);
	
	c=a;
	a=b;
	b=c;
	
	printf("\n\tO numero A e : %d",a);
	printf("\n\tO numero B e : %d",b);
	
	return 0;
}
