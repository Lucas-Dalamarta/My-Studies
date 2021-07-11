int main()
{
	char n='-';
	int x=2 , y=1 ,to=0 , tb=0 , tr=0 , tu=0 , c=0 , po=0 , pb=0 , pr=0 , pu=0 ;
	int sob , sru ;//somas de notas ob e ru//
		
	while(x!=y){
		printf("Digite a nota :\n");n=getchar();
			switch(n){
				case 'o':to++;c++;break;
				case 'b':tb++;c++;break;
				case 'r':tr++;c++;break;
				case 'u':tu++;c++;break;
				case '-':x=y;break;
				default: printf("Nota invalida\n");getchar();break;
					}
	getchar();
	}
	po=100/c*to;	pb=100/c*tb;	pr=100/c*tr;	pu=100/c*tu;
	sob=to+tb;	sru=tr+tu;
	
	printf("\tTotal de respostas validas : %d\n",c);
	printf("\tTotal de votos : O=%d B=%d R=%d U=%d\n",to,tb,tb,tu);
	printf("\tPorcentagem de votos dO=%d%% B=%d%% R=%d%% U=%d%%\n",po,pb,pr,pu);
	
	if(sob>sru){printf("\tSoma de O+B e maior que R+U\n");}
	else{printf("\tSoma de O+B menor que R+U\n");}
	
	return 0;
}
