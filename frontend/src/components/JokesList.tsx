import { FC, useEffect, useState } from "react";
import styled from "styled-components";
import { JokeServerData, useGetJokes } from "../Network";

const JokesListContainer = styled("div")({});

const StyledJokesList = styled("div")({
  marginTop: "10px",
  display: "flex",
  padding: "25px",
  borderBottom: "1px solid black",
  flexDirection: "column",
  gap: "20px",
  maxHeight: "300px",
  overflowY: "scroll",
});

const JokeWrapper = styled("div")({
  display: "flex",
  gap: "20px",
});

const JokeContent = styled("div")({
  padding: "15px",
  borderRadius: "6px",
  border: "1px solid black",
  backgroundColor: "white",
  flexGrow: 1,
});

const JokeText = styled("p")({
  fontSize: "14px",
});

const AuthorName = styled("p")({
  marginTop: "10px",
  fontSize: "12px",
  color: "grey",
});

const Reviewer = styled("div")({
  display: "flex",
  flexDirection: "column",
  alignItems: "center",
  justifyContent: "center",
});

const Vote = styled("div")<{ $upVote?: boolean }>(({ $upVote = false }) => ({
  cursor: "pointer",
  width: "22px",
  height: "22px",
  borderRadius: "50%",
  backgroundColor: "red",
  textAlign: "center",
  color: "white",
  ...($upVote && { backgroundColor: "green" }),
}));

const Joke: FC<{ jokeObject: JokeServerData }> = ({ jokeObject }) => {
  return (
    <JokeWrapper>
      <JokeContent>
        <JokeText>{jokeObject.content}</JokeText>
        <AuthorName>
          {jokeObject.authorName && `Dodane przez: ${jokeObject.authorName}`}
        </AuthorName>
      </JokeContent>
      <Reviewer>
        <Vote $upVote>+</Vote>
        <p>{jokeObject.votes}</p>
        <Vote>-</Vote>
      </Reviewer>
    </JokeWrapper>
  );
};

const JokesList = () => {
  const jokesQuery = useGetJokes();
  const [jokes, setJokes] = useState<JokeServerData[]>();

  useEffect(() => {
    if (jokesQuery.data && jokesQuery.isSuccess) {
      setJokes(jokesQuery.data);
    }
  }, [jokesQuery.data, jokesQuery.isSuccess]);

  return (
    <JokesListContainer>
      <h2>Sprawdz nasze żarty!</h2>
      <StyledJokesList>
        {jokes && jokes.map((joke) => <Joke jokeObject={joke} />)}
      </StyledJokesList>
    </JokesListContainer>
  );
};

export default JokesList;
