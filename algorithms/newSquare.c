#include <stdio.h>
#define MAX 1000

int main() {
    int width, height;
    int coordinates[MAX][MAX];
    int index = 0;

    //we will take these variables from the GUI
    printf("Input the width: ");
    scanf("%d", &width);
    
    printf("Input the height: ");
    scanf("%d", &height);
    
    for (int j = 0; j <= width; j++) {
        if (j % 2 == 0) {
            for (int i = 0; i <= height; i++) {
                coordinates[j][index] = i;
                coordinates[j][index + 1] = j;
                index += 2;
                printf("%d %d\n", i, j);
            }
        } else {
            for (int i = height; i >= 0; i--) {
                coordinates[j][index] = i;
                coordinates[j][index + 1] = j;
                index += 2;
                printf("%d %d\n", i, j);
            }
        }
        index = 0;
    }
    return 0;
}
