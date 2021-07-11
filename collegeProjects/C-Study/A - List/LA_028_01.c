int main()
{
	float vc , res2;
	int res1 ;
	printf("Digite o valor da conta :\n");scanf("%f",&vc);
	res1=vc/3;
	res2=vc-(res1+res1);
	printf("Cheiroso e Chule pagarao :%.2d\n",res1);
	printf("Pirriu pagara : %.2f\n",res2);
	return 0;
}
