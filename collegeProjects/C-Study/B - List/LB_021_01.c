int main()
{
	char bola ;
	
	printf("Codigo da bola:\n\t{p}\n\t{b}\n\t{v}\n\t{a}\n\t{l}\n");scanf("%c",&bola);
	
	switch(bola)
	{
		case'p':printf("+10 pontos\n");break;
		case'P':printf("+10 pontos\n");break;		
		case'b':printf("+15 pontos\n");break;
		case'B':printf("+15 pontos\n");break;		
		case'v':printf(" +0 pontos\n");break;
		case'V':printf(" +0 pontos\n");break;		
		case'a':printf("-15 pontos\n");break;
		case'A':printf("-15 pontos\n");break;		
		case'l':printf("-10 pontos\n");break;
		case'L':printf("-10 pontos\n");break;		
	}
	return 0;
	
}
