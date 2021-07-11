int main()
{
	int i , id , qrp=0 , qro=0 , qrr=0 , mir=0 , mip=0 , pp=0;
	char op;
	for(i=0;i<100;i++){
		printf("Digite a idade :\n");scanf("%d",&id);
		getchar();
		printf("Escolha a nota [otimo=o],[bom=b],[regular=e],[ruim=r],[pessimo=p]\n");scanf("%c",&op);
		switch(op){
			case 'o':qro++;break;
			case 'r':qrr++;mir=id+mir;break;
			case 'p':{if(id>mip){mip=id;}qrp++;break;	
			default : printf("\n");break;	
		}
		getchar();	
	}}   
	pp=qrp*100/i;
	mir=mir/qrr;
	printf("Quantidade otimo %d\n",qro);
	printf("Media id ruim %d\n",mir);
	printf("Porcent %d\n",pp);
	printf("Maior idade pes%d\n",mip);
	
	return 0;
}
