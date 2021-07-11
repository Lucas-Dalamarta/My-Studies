int main()
{
	int c , n , a , s ;
	c=0;a=0;
	printf("Digite N:\n");scanf("%d",&n);
	
	while(c<n){
		printf("Digite o numero a somar :\n");scanf("%d",&s);
		a=a+s;
		c=c+1;
	}
	
	printf("\n\tResultado da soma dos numeros = %d",a);
	return 0;
}
