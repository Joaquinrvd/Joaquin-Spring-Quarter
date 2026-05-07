//
//  Lesson_5.swift
//  Spring Project
//
//  Created by Joaquin Robert Vincent-DaGrace on 5/6/26.
//

import SwiftUI

struct Lesson_5: View {
    var body: some View {
        TabView{
            
            Session_2()
                .tabItem{
                    Label("Session 2", systemImage: "book.closed.fill")
                }
            ContentView()
                .tabItem{
                    Label("ContentView", systemImage: "lightbulb.fill")
                }
            
            AboutJoaquin()
                .tabItem{
                    Label("AboutGame", systemImage: "person.fill")
                }
        }
        
    }
    
}

#Preview {
    Lesson_5()
}

