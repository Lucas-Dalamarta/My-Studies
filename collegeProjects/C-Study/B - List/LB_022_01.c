int main()
{
	int o1 , o2 , o3 , o4 ;
	
	printf("Digite o primeiro octeto :\n");scanf("%d",&o1);
	printf("Digite o segundo octeto :\n");scanf("%d",&o2);
	printf("Digite o terceiro octeto :\n");scanf("%d",&o3);
	printf("Digite o quarto octeto :\n");scanf("%d",&o4);	
	
	switch(o1)
	{
		case 126 :printf("CLASSE A\n");break;
		case 191 :printf("CLASSE B\n");break;
		case 223 :printf("CLASSE C\n");break;
		default  :printf("IP INVALIDO\n");break;
	}
	
}
