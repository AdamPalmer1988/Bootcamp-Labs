package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        List<Movie> movieList = List.of(new Movie("Toy Story", "Animation"),
                new Movie("Forrest Gump", "Drama"),
                new Movie("Castaway", "Action"));

        Scanner scanner = new Scanner(System.in);

        String keepPlaying = "yes";

        while (keepPlaying.equalsIgnoreCase("yes")) {
            int movieCount = 0;

            System.out.println("Hello, please input a category");
            String inputCategory = scanner.nextLine();

            for (Movie movie : movieList) {
                if (inputCategory.equalsIgnoreCase(movie.getCategory())) {
                    System.out.println(movie.getTitle());
                    movieCount++;
                }
            }

            if (movieCount == 0) {
                System.out.println("We did not have a catagory by that name");
            }

            System.out.println("Would you like to try again?");
            keepPlaying = scanner.nextLine();
        }
    }
}

