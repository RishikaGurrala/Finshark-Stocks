import React from 'react'
import { CommentGet } from '../../Models/Comment';
import StockCommentsListItem from '../StockCommentsListItem/StockCommentsListItem';

type Props = {
    comments: CommentGet[];
}

const StockCommentsList = ({comments}: Props) => {
  return (
    <>
   {comments? comments.map((comment) => {
         return <StockCommentsListItem comment={comment} />
   }): " "}
   </>
  )
}

export default StockCommentsList