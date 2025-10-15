#include <stdio.h>

int main() {
    int width, height;
    printf("input the width \n");
    scanf("%d", &width);
    
    printf("input the height \n");
    scanf("%d", &height);
    
    char data [TMP_MAX];
    int i=0,j=0, x=0;
    for (j = 0; j <= width; j++) {
        if (j % 2 == 0) {
            for (i = 0; i <= height; i++) {
                printf("%d %d\n", i, j);
 
                }
        } else {
            for (i = height; i >= 0; i--) {
                printf("%d %d\n", i, j);
 
                }
        }
    }

    return 0;
}
