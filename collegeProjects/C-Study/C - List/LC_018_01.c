int main()
{
	int cont =1 , a , b , acu = 0 ;

	printf("Digite o numero A\n");scanf("%d",&a);
	printf("Digite o numero B\n");scanf("%d",&b);	
	while(cont<=b){
		acu=acu+a;
		cont++;
	}
	printf("%d x %d = %d",a,b,acu);
	return 0;
}
