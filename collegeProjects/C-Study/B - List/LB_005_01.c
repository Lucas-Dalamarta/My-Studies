int main()
{
	float n1 , n2 ;
	
	printf("Digite um valor em metros :\n");
	scanf("%f",&n1);
	
	if(n1>=0)
	{
		n2=n1*3.315;
		
		printf("%.2f Metros = %.3f Pes",n1,n2);	
	}
	else
	{
		printf("Numero invalido\n");
	}
	
	return 0;
}
