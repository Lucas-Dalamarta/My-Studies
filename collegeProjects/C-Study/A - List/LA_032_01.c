int main()
{
	float qtl , qtg06 , qtg2 , total ;
	
	printf("Digite lata :\n");scanf("%f",&qtl);
	printf("Digite garrafa 600 Ml\n");scanf("%f",&qtg06);
	printf("Digita garrafa 2 L\n");scanf("%f",&qtg2);
	
	total=(qtl*0.350)+(qtg06*0.600)+(qtg2+2);
	
	printf("%.2f litros",total);
	return 0;
}
