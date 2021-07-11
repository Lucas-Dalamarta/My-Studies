int main()
{
	int m , a , d , id ;
	
	printf("Digite quantos anos : \n");
	scanf("%d",&a);
	printf("Digite quantos meses : \n");
	scanf("%d",&m);
	printf("Digite quantos dias : \n");
	scanf("%d",&d);
	
	a=a*365;
	m=m*30;
	
	id=d+m+a;
	
	printf("\n Voce tem : %d dias de vida ",id);
	
	return 0;
	
	
}
