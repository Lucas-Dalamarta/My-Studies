int main()
{
	int vs , qt1 , qt5 , qt10 , qt50 , res1 ;
	printf("Digite o valor a ser sacado :\n");
	scanf("%d",&vs);
	
	qt50=vs/50;
	res1=vs-qt50*50;
	qt10=res1/10;
	res1=res1-qt10 *10;
	qt5=res1/5;
	res1=res1-qt5*5;
	qt1=res1/1;
	
	printf(" %d de 50 \n %d de 10\n %d de 5\n %d de 1",qt50,qt10,qt5,qt1);
	
	return 0;
	
	 
}
