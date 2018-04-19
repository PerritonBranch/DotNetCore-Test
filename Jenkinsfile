pipeline {
  agent {
    docker {
      args '''-p 3000:3000
'''
      image 'microsoft/dotnet:2.0-runtime'
    }

  }
  stages {
    stage('AddDocker') {
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
      }
    }
    stage('TestDockerCommands') {
      steps {
        sh 'docker --version'
        sh 'docker ps'
        sh 'docker run hello-world'
      }
    }
  }
}