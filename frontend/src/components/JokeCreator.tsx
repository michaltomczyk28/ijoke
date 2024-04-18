import { useState } from "react";
import styled from "styled-components";
import { JokeProperties, useCreateJoke } from "../Network";
import { useQueryClient } from "@tanstack/react-query";

const CreatorContainer = styled("div")({
  margin: "0 auto",
  width: "100%",
});

const CreatorForm = styled("div")({
  marginTop: "10px",
  display: "flex",
  padding: "25px",
  flexDirection: "column",
  gap: "20px",

  input: {
    padding: "15px",
    borderRadius: "6px",
    border: "1px solid black",
  },

  button: {
    cursor: "pointer",
    padding: "5px",
    borderRadius: "6px",
    border: "1px solid black",
  },
});

const Message = styled("p")<{ $success?: boolean }>(({ $success }) => ({
  color: $success ? "green" : "red",
  textAlign: "center",
}));

const JokeCreator = () => {
  const createJoke = useCreateJoke();
  const queryClient = useQueryClient();
  const [jokeData, setJokeData] = useState<JokeProperties>({
    content: "",
    authorName: "",
  });

  const inputChangeHandler = (e: React.ChangeEvent<HTMLInputElement>) => {
    e.target.id && setJokeData({ ...jokeData, [e.target.id]: e.target.value });
    createJoke.reset();
  };

  const onAddClick = () => {
    createJoke.mutate(jokeData, {
      onSuccess: () => queryClient.invalidateQueries({ queryKey: ["jokes"] }),
    });
  };

  return (
    <CreatorContainer>
      <h2>Dodaj nowy zart!</h2>
      <CreatorForm>
        <input
          id="content"
          required
          placeholder="Treść żartu"
          onChange={inputChangeHandler}
          disabled={createJoke.isPending}
        />
        <input
          id="authorName"
          style={{ width: "25%" }}
          placeholder="Autor"
          onChange={inputChangeHandler}
          disabled={createJoke.isPending}
        />
        <button onClick={onAddClick} disabled={createJoke.isPending}>
          Dodaj
        </button>
        {createJoke.isSuccess && (
          <Message $success>Udało się dodać żart!</Message>
        )}
        {createJoke.isError && <Message>Błąd przy dodawaniu żartu..</Message>}
      </CreatorForm>
    </CreatorContainer>
  );
};

export default JokeCreator;
