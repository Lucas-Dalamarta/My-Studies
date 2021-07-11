// EN :		These are functions created to help developing the main project
// PT :		Essas fun�oes foram criadas com o intuito de facilitar o desenvolvimento do projeto

void f(int i , int cont){
	
	int n;
	int i;

	for(n=0;n<cont;n++){
		switch(i){
			case 0:	{	printf("\n");	break;	}
			case 1:{	
				for(i = 0 ; i < 120 ; i++){
					if ((i == 0) ||	(i == 120))	{
						printf("||");
					}	else	{
						printf("=");
					}
				}
					f(0,1);
				break;
			}
			case 2:	{
				for(i = 0 ; i < 120 ; i++){
					if ((i == 0) ||	(i == 120))	{
						printf("||");
					}	else	{
						printf("-");
					}
				}
				f(0,1);
			break;
			}		
			case 3:	{	getchar();		break;	}
			case 4:	{	printf("\7");	break;	}
			case 5:	{	system("cls");	break;	}
			case 6:{
				printf("\n\t PROGRAMA ENCERRADO\t APPLICATION ENDED \n");
				f(2,1);	
				exit(1);
			break;
			} 
		}	
	}	
}
