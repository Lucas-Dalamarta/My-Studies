int main()
{
	float vt , pt ;
	int tp , tb ;

	printf("Digite o total de paes vendidos :\n");
	scanf("%d",&tp);
	printf("Digite o total de broas vendidas :\n");
	scanf("%d",&tb);
	
	tp=tp*0.12;
	tb=tb*1.5;
	vt=tp+tb;
	pt=vt*0.10;
	
	printf("O valor total arrecadado e : %.2f",vt);
	printf("\nO valor total a ser poupado e : %.2f",pt);
	
	return 0;
	
}
