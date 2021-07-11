int main()
{
	int S ;
	float p , q , h ;
	
	printf("Informe o total de sanduiches a serem feitos :\n");
	scanf("%d",&S);
	
	p=S*0.050;
	q=S*0.100;
	h=S*0.100;
	
	printf("\nO total de Queijo e :\t\t%.1f Kgs",q);
	printf("\nO total de Presunto e :\t\t%.1f Kgs",p);
	printf("\nO total de Hamburgueres e :%.1f Kgs",h);
	
	return 0;
}
