int main()
{
	int se , te , qa , qi , sx , sa , dm , me ;
	
	printf("---------Weekly average temperature---------\n");
	printf("Insert Monday 		:\n");
	scanf("%d",&se);
	printf("Insert Tuesday 		:\n");
	scanf("%d",&te);
	printf("Insert Wednesday 	:\n");
	scanf("%d",&qa);
	printf("Insert Thursday 	:\n");
	scanf("%d",&qi);
	printf("Insert Friday 		:\n");
	scanf("%d",&sx);
	printf("Insert Saturday		:\n");
	scanf("%d",&sa);
	printf("Insert Sunday 		:\n");
	scanf("%d",&dm);
	
	me=(se+te+qa+qi+sx+sa+dm)/7;
	
	printf("\nThe average temperature was : %d",me);
	
	return 0;
}
