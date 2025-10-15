/*
#define MAX_WIDTH 50
#define MAX_HEIGHT 50

// Koordinatları saklamak için iki boyutlu dizi
int coordinates[MAX_WIDTH][MAX_HEIGHT][2];

void calculateCoordinates(int width, int height) {
    int index = 0;
    for (int j = 0; j <= width; j++) {
        if (j % 2 == 0) {
            for (int i = 0; i <= height; i++) {
                coordinates[j][index][0] = i;
                coordinates[j][index][1] = j;
                index++;
            }
        } else {
            for (int i = height; i >= 0; i--) {
                coordinates[j][index][0] = i;
                coordinates[j][index][1] = j;
                index++;
            }
        }
        index = 0;
    }
}

void setup() {
    // Seri iletişimi başlat
    Serial.begin(9600);
    
    int width = 10;  // Genişlik değeri (GUI'den alınabilir)
    int height = 5;  // Yükseklik değeri (GUI'den alınabilir)
    
    calculateCoordinates(width, height);
    
    // Koordinatları yazdır debugging 
    for (int j = 0; j <= width; j++) {
        for (int i = 0; i <= height; i++) {
            Serial.print("i: ");
            Serial.print(coordinates[j][i][0]);
            Serial.print(", j: ");
            Serial.println(coordinates[j][i][1]);
        }
    }
}

void loop() {
}
*/