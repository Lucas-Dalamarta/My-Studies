int main()
{
	float p0 , v , a , pf ;
	int t ;
	
	printf("Informe a posicao inicial :\n");scanf("%f",&p0);
	printf("Informe a velocidade :\n");scanf("%f",&v);
	printf("Informe a aceleracao :\n");scanf("%f",&a);
	printf("Informe o tempo decorrido :\n");scanf("%d",&t);
	
	pf=p0+v*t+(a*(t*2))/2;
	printf("POSICAO FINAL :%.f",pf);
	return 0;
}
