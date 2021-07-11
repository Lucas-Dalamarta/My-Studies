int main()
{
	int r[10] , n , i;
	
	printf("Digite o numero:\n");scanf("%d",&n);
	for(i=0;i<10;i++){
		r[i]=n*i;
	}
	for(i=0;i<10;i++){
		if(i==0){printf("Ordem crescente :\n");}
		printf("%d x %d= %d\n",n,i,r[i]);
	}
	for(i=9;i>=0;i--){
		if(i==9){printf("Ordem decrescente :\n");}
		printf("%d x %d = %d\n",n,i,r[i]);
	}
	system("pause");
}
