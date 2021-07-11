int main()
{
	float cc , cf , pd , ci ;
	
	printf("Digite o valor de fabrica do carro :\n");
	scanf("%f",&cf);
	
	pd=cf*0.12;
	ci=cf*0.45;
	
	cc=cf+ci+pd;
	
	printf("\nO valor final do carro para o consumidor e de : %.2f",cc);
	
	return 0;
}
