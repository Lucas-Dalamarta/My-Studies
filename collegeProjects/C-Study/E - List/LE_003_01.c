char ni(char txt[]){
	
	int i ;
	for(i=strlen(txt)-1;i>=0;i--){
		printf("%c",txt[i]);
	}	
	return txt;
}
int main()
{
	char txt[100];
		
	printf("Digite seu nome :\n");gets(txt);

	ni(txt);
	
	return 0;
}

