int main()
{
	int c , a , s ;
	c=-1;a=0;
	
	while(c!=0){
		printf("Digite o numero a somar :\n");scanf("%d",&s);
		a=a+s;
		if(s==0){c=0;}
	}
	
	printf("\nResultado da soma dos numeros = %d",a);
	return 0;
}
