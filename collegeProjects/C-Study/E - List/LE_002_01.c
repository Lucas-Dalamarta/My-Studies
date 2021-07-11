float su(float n1 , float n2){
	return n1-n2;
}
float ad(float n1 , float n2){
	return n1+n2;
}
float di(float n1 , float n2){
	return n1/n2;
}
float mu(float n1 , float n2){
	return n1*n2;
}
int main(){
	float n1 , n2 , r ;	char op , cont;

	do{	
		
		printf("Digite n1:\n");scanf("%f",&n1);
		printf("Digite n2:\n");scanf("%f",&n2);
		getchar();
		
		printf("\ta = Subtracao\n\tb = Adicao\n\tc = Divisao\n\td = Multiplicacao\n");op=getchar();
		
		switch(op){
			case 'a':r=su(n1,n2);	printf("%.2f - %.2f = %.2f",n1,n2,r);	break;
			case 'b':r=ad(n1,n2);	printf("%.2f + %.2f = %.2f",n1,n2,r);	break;
			case 'c':r=di(n1,n2);	printf("%.2f X %.2f = %.2f",n1,n2,r);	break;
			case 'd':r=mu(n1,n2);	printf("%.2f / %.2f = %.2f",n1,n2,r);	break;
			default:printf("Opcao invalida\n");break;
		}
		getchar();
		
		printf("\nDeseja fazer outra operacao [s|n]?\n");cont=getchar();
	
	}while(cont=='s');
	
	printf("=====================FIM DO PROGRAMA=====================\n");
		
	return 0;
}
