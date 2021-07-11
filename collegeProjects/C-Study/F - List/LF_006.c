#define TAM 50
typedef struct{
	char placa[8];
	char marca[15];
	char hora[5];
}entrada;
	//Haja dificuldade pra fazer esse exs.
char ObterDadosDaVaga(entrada vagas[]){
	int i;
	
	for(i=0;i<TAM;i++){
		printf("Vaga %d",i);
		printf("\n\tHora  :");	gets(vagas[i].hora);
		printf("\n\tMarca :");	gets(vagas[i].marca);
		printf("\n\tPlaca :");	gets(vagas[i].placa);
		printf("\n");
	}
	
	return vagas;
}
	
int main(){
	int i;
	entrada vagas[50];
	
 	ObterDadosDaVaga(vagas);
 	
	for(i=0;i<TAM;i++){
		printf("\nVaga %d",i);
		printf("\n\tHora  : %s",vagas[i].hora);
		printf("\n\tMarca : %s",vagas[i].marca);
		printf("\n\tPlaca : %s",vagas[i].placa);	
	}
}
